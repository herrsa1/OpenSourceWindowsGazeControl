using EyeXFramework;
using EyeXFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeToolBar
{
    //enums to represent different states or functions.
    //System state
    public enum SystemState { Wait, ActionButtonSelected, Zooming, ZoomWait, ApplyAction, ScrollWait }
    //Action to be preformed once the cycle of states has completed, eg which action was select from the gaze tool bar
    public enum ActionToBePerformed { RightClick, LeftClick, DoubleClick, Scroll }
    //Represents if the fixation was in the corner of the screen, lets state manager know if needs to recompute coordinates.
    public enum Corner { NoCorner = -1, TopLeft, TopRight, BottomLeft, BottomRight }
    //Represents if the fixation was near and edge and recomputes the coordinates.
    public enum Edge { NoEdge = -1, Top, Right, Bottom, Left, TopLeft, TopRight, BottomLeft, BottomRight }

    //Class that has system flags, all objects can access this, allows basic messages to be passed between objects with out setting up observers and subscribers.
    public static class SystemFlags
    {
        public static bool isKeyBoardUP { get; set; }
        public static bool actionButtonSelected { get; set; }
        public static ActionToBePerformed actionToBePerformed { get; set; }
        public static SystemState currentState { get; set; }
        public static bool gaze { get; set; }
        public static bool timeOut { get; set; }
        public static bool fixationRunning { get; set; }
        public static bool hasSelectedButtonColourBeenReset { get; set; }
        public static bool scrolling { get; set; }
        public static bool shortCutKeyPressed { get; set; }
    }

    //State manager class
    public class StateManager
    {
        //Fields
        public FixationDetection fixationWorker;
        ScrollControl scrollWorker;
        Form1 toolbar;
        ZoomLens zoomer;
        Point fixationPoint;
        Corner corner;
        Edge edge;
        SystemState currentState;
        FormsEyeXHost eyeXHost;
        bool cornerBool = false;
        bool edgeBool = false;
        ShortcutKeyWorker ShortCutKeyWorker;
        
        //Constructor
        public StateManager(Form1 Toolbar, ShortcutKeyWorker shortCutKeyWorker, FormsEyeXHost EyeXHost)
        {
            //set reference passed in eyeX object and gaze toolbar.
            eyeXHost = EyeXHost; //(In future when decoupled from the eyeX a class or interface will be passed in here depending on what eye tracker is passed in. eg Strategy pattern)
            toolbar = Toolbar;

            //Set initial state to waiting
            SystemFlags.currentState = SystemState.Wait;

            //Instantiate fixation working and pass in reference to eyex engine object. (In future when decoupled from the eyeX a class or interface will be passed in here depending on what eye tracker is passed in. eg Strategy pattern)
            fixationWorker = new FixationDetection(eyeXHost);

            //Instantiate scrolworker and set dead zone boundarys
            scrollWorker = new ScrollControl(200, 5, 50, 20, eyeXHost);//(In future when decoupled from the eyeX a class or interface will be passed in here depending on what eye tracker is passed in. eg Strategy pattern)

            SystemFlags.hasSelectedButtonColourBeenReset = true;

            //Instantiate zoomer object (zoom window that appears when 2nd fixation is required for better accuracy),(In future when decoupled from the eyeX a class or interface will be passed in here depending on what eye tracker is passed in. eg Strategy pattern)
            zoomer = new ZoomLens(fixationWorker, eyeXHost);

            //Console.WriteLine(scrollWorker.deadZoneRect.LeftBound + "," + scrollWorker.deadZoneRect.RightBound + "," + scrollWorker.deadZoneRect.TopBound + "," + scrollWorker.deadZoneRect.BottomBound);
            
            //Corner object used to detect and recompute coordinates for fixations close to corners.
            corner = new Corner();

            ShortCutKeyWorker = shortCutKeyWorker;

            //start loop that runs statemanager.
            Run();

        }

        //Called by loop on form, runs that state manager
        public void Run()
        {
            UpdateState();
            Action();
        }

        public void EnterWaitState()
        {
            //these flags are here so that they get reset before anything else happens in the SM
            //these were previously in the action method but that causes issues because the update state is run again before all of the flags are reset.
            SystemFlags.fixationRunning = false;
            SystemFlags.actionButtonSelected = false;
            SystemFlags.fixationRunning = false;
            SystemFlags.gaze = false;
            SystemFlags.timeOut = false;
            fixationWorker.IsZoomerFixation(false);
            currentState = SystemState.Wait;
        }
        //The update method is responsible for transitioning from state to state. Once a state is changed the action() method is run
        public void UpdateState()
        {
            //Get current state from systemflags
            currentState = SystemFlags.currentState;
            switch (currentState)
            {//Normally in wait state if nothing is been selected from the gaze tool bar.
                case SystemState.Wait:
                    //If the button has been selected from the gaze tool bar, the actionbuttonselected flag will be set to true.
                    if (SystemFlags.actionButtonSelected) //if a button has been selected from the toolbar
                    {
                        //the currente state is set to action button selected
                        currentState = SystemState.ActionButtonSelected;
                        //the system flag is set back to false so not to go back into here next time the loop runs.
                        SystemFlags.actionButtonSelected = false;
                        //drops of the case statement
                    }
                    else if (SystemFlags.shortCutKeyPressed)
                    {
                        //if the short cut key flag is raised go straight to the zooming state
                        currentState = SystemState.Zooming;
                    }
                    break;
                case SystemState.ActionButtonSelected:
                    //the system is now waiting for a fixation to happen, set selected button flag to false, so the form knows to reset button colours once the full process
                    // of selecting a button, doing first fixation then second fixation and applying action at final coordinates.
                    SystemFlags.hasSelectedButtonColourBeenReset = false;
                    
                    //check checking  until a successful fixation is dectected and the fixation worker sets systemflag.gaze to true, or no fixation is detected and the systems times out and goes back to the wait state.
                    if (SystemFlags.gaze)
                    {
                        //if a fixation was detected  the fist fixation is complete and the system can get coordinates from the fixation worked of where to show the zoomer window to then complete the second fixation.
                        //Set the current state to zooming and drop out of the case statement. Goto Zooming Action.
                        currentState = SystemState.Zooming;
                    }
                    else if (SystemFlags.timeOut)
                    {
                        //on time out reset all flags and go back to waiting.
                        EnterWaitState();
                        SystemFlags.timeOut = false;
                    }
                    break;
                case SystemState.Zooming:
                    //If action to be taken is scrolling, dont show zoomer go straight to scrolling action, by changing state to Apply action.
                    if (SystemFlags.actionToBePerformed == ActionToBePerformed.Scroll)
                    {
                        currentState = SystemState.ApplyAction;
                    }
                    else
                    {
                        //Else wait for the zoom fixation to complete
                        currentState = SystemState.ZoomWait;
                        //Goto zoomwait action
                    }
                    break;
                case SystemState.ZoomWait:
                    if (SystemFlags.gaze)//if the second zoomGaze has happed an action needs to be performed, change state to apply action go to applaction action
                    {
                        currentState = SystemState.ApplyAction;
                    }
                    // if no fixation happens because it times out, go back to wait state.
                    else if (SystemFlags.timeOut)
                    {
                        EnterWaitState();
                        zoomer.ResetZoomLens();
                    }
                    break;
                case SystemState.ScrollWait:
                    if (!SystemFlags.scrolling)
                    {
                        EnterWaitState();
                    }
                    break;
                case SystemState.ApplyAction:
                    if (SystemFlags.scrolling)
                    {
                        currentState = SystemState.ScrollWait;
                        //go to action
                    }
                    else
                    {
                        EnterWaitState();
                    }
                    break;
            }

            //current state saved to system flags, could probaby be got rid of, saving same state in 2 places.
            SystemFlags.currentState = currentState;
        }
        
        //The action state is responsible for completing each action that must take place during each state
        public void Action()
        {//swtich depending on when state has been set
            switch (SystemFlags.currentState)
            {
                case SystemState.Wait:
                    if (SystemFlags.hasSelectedButtonColourBeenReset == false)
                    {
                        toolbar.resetButtonsColor();
                        SystemFlags.hasSelectedButtonColourBeenReset = true;
                    }
                    break;
                case SystemState.ActionButtonSelected:
                    //if and action button is selected, stop scroll working from inputing scrolling actions(just encase it is still working some how)
                    scrollWorker.stopScroll();
                    //Check if a fixation is already running, if not start detecting a fixation
                    if (!SystemFlags.fixationRunning)
                    {
                        fixationWorker.StartDetectingFixation();
                        //Set system flag to true for so that the system knows a fixation is being detected (not to be confused with the statemanager 
                        //current state, it is still set as action button selected.) and drop out of the case statement
                        SystemFlags.fixationRunning = true;
                    }
                    break;
                case SystemState.Zooming:
                    //turn off top 15% of screen fix to allow easier fixation when not fixating in zoomer.
                    fixationWorker.IsZoomerFixation(true);

                    //Check if zoom is required from shourt cut key press or fro fixation worker.
                    if (SystemFlags.shortCutKeyPressed)//if a user defined click key is pressed
                    {
                        //get coordinate of where user was looking when short cut key was pressed
                        fixationPoint = ShortCutKeyWorker.GetXY();
                        SystemFlags.shortCutKeyPressed = false;
                    }
                    else
                    {//get coordinate of fixation
                        fixationPoint = fixationWorker.getXY();//get the location the user looked
                    }
                    //zoomLens setup
                    zoomer.determineDesktopLocation(fixationPoint);
                    //checking if the user looked in a corner
                    corner = zoomer.checkCorners(fixationPoint);
                    //Checking if a user looked near an edge
                    edge = zoomer.checkEdge();
                    cornerBool = false;
                    edgeBool = false;

                    if (corner != Corner.NoCorner)//if the user looked in a corner
                    {
                        zoomer.setZoomLensPositionCorner(corner);//set the lens into the corner
                        cornerBool = true;
                    }
                    else if (edge != Edge.NoEdge)//if there is no corner and the user looked near the edge of the screen
                    {
                        zoomer.setZoomLensPositionEdge(edge, fixationPoint);//set lens to edge
                        edgeBool = true;
                    }

                    zoomer.TakeScreenShot();//This is taking the screenshot that will be zoomed in on
                    zoomer.CreateZoomLens(fixationPoint);//create a zoom lens at this location
                    //disable neccesary flags
                    //past first fixation, on to second fixation on zoomer window/lens
                    SystemFlags.gaze = false;
                    SystemFlags.fixationRunning = false;
                    //Got to zooming update state.
                    break;
                case SystemState.ZoomWait://waiting for user to fixate
                    if (!SystemFlags.fixationRunning)
                    {    //Start fixation working detecting  fixations, set system flag(not state) to fixation running                    
                        fixationWorker.StartDetectingFixation();
                        SystemFlags.fixationRunning = true;
                        //Goto ZoomWait update state
                    }
                    break;
                case SystemState.ApplyAction: //the fixation on the zoom lens has been detected

                    //get loaction of fixation
                    fixationPoint = fixationWorker.getXY();
                    zoomer.ResetZoomLens();//hide the lens
                    fixationPoint = zoomer.TranslateGazePoint(fixationPoint);//translate the form coordinates to the desktop

                    //Checking if the user has zoomed in on an edge or a corner and offsetting the zoomed in click calculations to account for the
                    //different location of the screenshot
                    //e.g when a corner is selected the program zooms into the corner instead of the middle of the zoomlens, this means that for the final point to be accurate
                    //there must be an offset to account for the different zoom direction.
                    if (cornerBool)
                    {
                        fixationPoint = zoomer.cornerOffset(corner, fixationPoint);
                    }
                    else if (edgeBool)
                    {
                        fixationPoint = zoomer.edgeOffset(edge, fixationPoint);
                    }
                    if (fixationPoint.X == -1)//check if it's out of bounds
                    {
                        EnterWaitState();
                    }
                    else
                    {
                        //execute the appropriate action
                        if (SystemFlags.actionToBePerformed == ActionToBePerformed.LeftClick)
                        {
                            VirtualMouse.LeftMouseClick(fixationPoint.X, fixationPoint.Y);
                        }
                        else if (SystemFlags.actionToBePerformed == ActionToBePerformed.RightClick)
                        {
                            VirtualMouse.RightMouseClick(fixationPoint.X, fixationPoint.Y);
                        }
                        else if (SystemFlags.actionToBePerformed == ActionToBePerformed.DoubleClick)
                        {
                            VirtualMouse.LeftDoubleClick(fixationPoint.X, fixationPoint.Y);
                        }
                        else if (SystemFlags.actionToBePerformed == ActionToBePerformed.Scroll)
                        {
                            //set state to scroll wait, system waits while user scrolls
                            SystemFlags.currentState = SystemState.ScrollWait;
                            //until scroling is set to false by scroll control instance(it detects a user looking outside the screen bounds)
                            SystemFlags.scrolling = true;
                            VirtualMouse.SetCursorPos(fixationPoint.X, fixationPoint.Y);
                            scrollWorker.StartScroll();
                        }
                    }
                    break;
            }
        }
    }
}
