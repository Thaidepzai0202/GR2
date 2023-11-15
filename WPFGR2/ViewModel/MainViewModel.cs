using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFGR2.ViewModel
{
    public class MainViewModel 
    {
        public bool IsLoaded =false;
        //all
        public MainViewModel() {
            if (!IsLoaded)
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
        }
    }
}
