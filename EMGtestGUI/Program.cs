using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace EMG
{
  static class Program
  {
    private static EMGtestGUI EMGformGUI;
    /// <summary>
    /// Główny punkt wejścia dla aplikacji.
    /// </summary>
    [STAThread]
    static void Main()
    {
      try
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        
        EMGformGUI = new EMGtestGUI();
        Application.Run(EMGformGUI);
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
    }
  }

}
