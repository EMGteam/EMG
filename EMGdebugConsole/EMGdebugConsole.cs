using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EMG
{
  public partial class EMGdebugConsole : UserControl
  {
    public EMGdebugConsole()
    {
      InitializeComponent();

      this.consoleTextBox.TabStop = false;
      EMGdebugConsole.HideCaret(this.consoleTextBox.Handle);
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

    protected override void OnResize(EventArgs e) => base.OnResize(e);

    [DllImport("user32.dll")]
    static extern bool HideCaret(IntPtr hWnd);

    private void consoleTextBox_AnyEvent(object sender, EventArgs e) => HideCaret(this.consoleTextBox.Handle);

    private void consoleTextBox_AnyMouseEvent(object sender, MouseEventArgs e) => HideCaret(this.consoleTextBox.Handle);
  }
}
