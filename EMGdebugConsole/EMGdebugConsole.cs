using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMG
{
  public partial class EMGdebugConsole : UserControl
  {
    public EMGdebugConsole()
    {
      InitializeComponent();

      this.consoleTextBox.ReadOnly = true;
      this.consoleTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + " ~ " + "Witamy w oprogramowaniu " + System.AppDomain.CurrentDomain.FriendlyName.Replace(".exe", ""));
    }

    public void AddText(string str, bool dbg = false)
    {
      if (!dbg)
      {
        this.consoleTextBox.AppendText(Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + " ~ ");
      }
      else
      {
        this.consoleTextBox.AppendText(Environment.NewLine + "DBG ~ " + DateTime.Now.ToString("HH:mm:ss") + " ~ ");
      }
      this.consoleTextBox.AppendText(str);
      this.consoleTextBox.ScrollToCaret();
    }

    protected override void OnResize(EventArgs e)
    {
      //this.consoleTextBox.SetBounds(3, 3)
      base.OnResize(e);
    }
  }
}
