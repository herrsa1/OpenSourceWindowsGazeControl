using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GazeToolBar
{
    class KeyConverter //Converts Key type into the correct format for Send Keys.
    {
        public string Convert(Key key)
        {
            string convertedKey = Constants.KEY_NOT_VALID_MESSAGE;
            switch (key)
            {
                case Key.A:
                case Key.B:
                case Key.C:
                case Key.D:
                case Key.E:
                case Key.F:
                case Key.G:
                case Key.H:
                case Key.I:
                case Key.J:
                case Key.K:
                case Key.L:
                case Key.M:
                case Key.N:
                case Key.O:
                case Key.P:
                case Key.Q:
                case Key.R:
                case Key.S:
                case Key.T:
                case Key.U:
                case Key.V:
                case Key.W:
                case Key.X:
                case Key.Y:
                case Key.Z:
                    convertedKey = key.ToString();
                    break;
                case Key.D0:
                    convertedKey = "0";
                    break;
                case Key.D1:
                    convertedKey = "1";
                    break;
                case Key.D2:
                    convertedKey = "2";
                    break;
                case Key.D3:
                    convertedKey = "3";
                    break;
                case Key.D4:
                    convertedKey = "4";
                    break;
                case Key.D5:
                    convertedKey = "5";
                    break;
                case Key.D6:
                    convertedKey = "6";
                    break;
                case Key.D7:
                    convertedKey = "7";
                    break;
                case Key.D8:
                    convertedKey = "8";
                    break;
                case Key.D9:
                    convertedKey = "9";
                    break;
                case Key.NumLock:
                    convertedKey = "{NUMLOCK}";
                    break;
                case Key.NumPad0:
                    convertedKey = "{NUMPAD0}";
                    break;
                case Key.NumPad1:
                    convertedKey = "{NUMPAD1}";
                    break;
                case Key.NumPad2:
                    convertedKey = "{NUMPAD2}";
                    break;
                case Key.NumPad3:
                    convertedKey = "{NUMPAD3}";
                    break;
                case Key.NumPad4:
                    convertedKey = "{NUMPAD4}";
                    break;
                case Key.NumPad5:
                    convertedKey = "{NUMPAD5}";
                    break;
                case Key.NumPad6:
                    convertedKey = "{NUMPAD6}";
                    break;
                case Key.NumPad7:
                    convertedKey = "{NUMPAD7}";
                    break;
                case Key.NumPad8:
                    convertedKey = "{NUMPAD8}";
                    break;
                case Key.NumPad9:
                    convertedKey = "{NUMPAD9}";
                    break;
                case Key.F1:
                    break;
                case Key.F2:
                    break;
                case Key.F3:
                    break;
                case Key.F4:
                    break;
                case Key.F5:
                    break;
                case Key.F6:
                    break;
                case Key.F7:
                    break;
                case Key.F8:
                    break;
                case Key.F9:
                    break;
                case Key.F10:
                    break;
                case Key.F11:
                    break;
                case Key.F12:
                    break;
                case Key.Back:
                    break;
                case Key.CapsLock:
                    break;
                case Key.Delete:
                    break;
                case Key.Down:
                    break;
                case Key.Up:
                    break;
                case Key.Left:
                    break;
                case Key.Right:
                    break;
                case Key.End:
                    break;
                case Key.Enter:
                    break;
                case Key.Escape:
                    break;
                case Key.Home:
                    break;
                case Key.Insert:
                    break;
                case Key.PageDown:
                    break;
                case Key.PageUp:
                    break;
                case Key.PrintScreen:
                    break;
                case Key.Scroll:
                    break;
                case Key.Tab:
                    break;
                default:
                    break;
            }
            return convertedKey;
        }
    }
}
