using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeToolBar
{
    public partial class SidebarArrangementForm : Form
    {
        private List<Point> sidebarActionInitPositions = new List<Point>();
        private List<String> selectedActions = new List<String>();
        private List<Button> actionButtons = new List<Button>();
        private String selectionButton = "";
        private Dictionary<String, Button> buttonMap = new Dictionary<string, Button>();

        public Form1 sideForm;
        public SidebarArrangementForm(Form1 frm)
        {
            sideForm = frm;
        }

        public SidebarArrangementForm()
        {
            InitializeComponent();

            InitSidebarActions();
        }

        private void InitSidebarActions()
        {
            buttonMap.Add("left_click", btnActionLeftClick);
            buttonMap.Add("right_click", btnActionRightClick);
            buttonMap.Add("keyboard", btnActionKeyboard);
            buttonMap.Add("double_left_click", btnActionDoubleLeftClick);
            buttonMap.Add("scroll", btnActionScrollClick);
            buttonMap.Add("settings", btnActionSettings);

            actionButtons.Add(btnActionDoubleLeftClick);
            actionButtons.Add(btnActionLeftClick);
            actionButtons.Add(btnActionRightClick);
            actionButtons.Add(btnActionScrollClick);
            actionButtons.Add(btnActionKeyboard);
            actionButtons.Add(btnActionSettings);

            foreach(Button b in actionButtons)
            {
                sidebarActionInitPositions.Add(new Point(b.Left, b.Top));
            }

            foreach(String s in Program.readSettings.sidebar)
            {
                AddAction(s);
            }

        }

        public void AddAction(String actionString)
        {
            selectedActions.Add(actionString);
            RefreshActions();
        }

        public void RemoveAction(String actionString)
        {
            selectedActions.Remove(actionString);
            RefreshActions();
        }

        public void RefreshActions()
        {
            const int XPOS = 850;
            int yPos = 80;
            const int YGAP = 10;

            int ind = 0;
            foreach (Button b in actionButtons)
            {
                if (ButtonInSidebar(b))
                {
                    int selIndex = selectedActions.IndexOf(GetStringForButton(b));
                    int y = yPos + ((b.Height + YGAP) * selIndex);

                    b.Left = XPOS;
                    b.Top = y;
                }
                else
                {
                    b.Left = sidebarActionInitPositions[ind].X;
                    b.Top = sidebarActionInitPositions[ind].Y;
                }
                ind++;
            }
        }

        private Button GetButtonForString(String buttonString)
        {
            return buttonMap[buttonString];
        }

        private String GetStringForButton(Button button)
        {
            String actionString = buttonMap.First(x => x.Value == button).Key;

            return actionString;
        }

        public bool ButtonInSidebar(Button b)
        {
            foreach (String s in selectedActions)
            {
                Button actionButton = GetButtonForString(s);
                if (actionButton == b)
                {
                    return true;
                }
            }
           return false;
        }

        public void ActionButtonClick(Button b)
        {
            String buttonString = GetStringForButton(b);
            if(ButtonInSidebar(b))
            {
                if(!selectionButton.Equals(""))
                {
                    Button selButton = GetButtonForString(selectionButton);
                    selButton.BackColor = Color.Black;
                }

                selectionButton = buttonString;
                b.BackColor = Color.Red;
            }
            else
            {
                AddAction(buttonString);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!selectionButton.Equals("") && !selectionButton.Equals("settings"))
            {
                Button b = GetButtonForString(selectionButton);
                b.BackColor = Color.Black;

                RemoveAction(selectionButton);
                selectionButton = "";

                RefreshActions();
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (!selectionButton.Equals(""))
            {
                Button b = GetButtonForString(selectionButton);

                int currentIndex = selectedActions.IndexOf(selectionButton);
                if(currentIndex > 0)
                {
                    String temp = selectedActions[currentIndex];
                    selectedActions[currentIndex] = selectedActions[currentIndex -1];
                    selectedActions[currentIndex - 1] = temp;
                    RefreshActions();

                }

                b.BackColor = Color.Black;
                selectionButton = "";
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (!selectionButton.Equals(""))
            {
                Button b = GetButtonForString(selectionButton);

                int currentIndex = selectedActions.IndexOf(selectionButton);
                if (currentIndex < selectedActions.Count - 1)
                {
                    String temp = selectedActions[currentIndex];
                    selectedActions[currentIndex] = selectedActions[currentIndex + 1];
                    selectedActions[currentIndex + 1] = temp;
                    RefreshActions();
                }

                b.BackColor = Color.Black;
                selectionButton = "";
            }
        }

        //Called when an action button is clicked
        private void btnActionButtonClick_Click(object sender, EventArgs e)
        {
            ActionButtonClick((Button)sender);
        }

        //SAVE REMOVE THIS LATER
        private void button1_Click(object sender, EventArgs e)
        {
            Program.readSettings.sidebar = selectedActions.ToArray<string>();

            string settings = JsonConvert.SerializeObject(Program.readSettings);
            File.WriteAllText(Program.path, settings);

            sideForm.ArrangeSidebar(Program.readSettings.sidebar);
        }
    }
}
