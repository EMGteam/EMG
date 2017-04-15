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
  public partial class EMGforceSensor : UserControl
  {
    public EMGforceSensor()
    {
      InitializeComponent();
    }
    
    byte Interpolate(byte a, byte b, double p)
    {
      return (byte)(a * (1 - p) + b * p);
    }

    public void setValue(float value)
    {
      this.BackColor = getColor(Convert.ToInt32(value));
      /* SolidBrush myBrush = new SolidBrush(getColor(Convert.ToInt32(value)));
      Graphics formGraphics;
      formGraphics = this.CreateGraphics();
      formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, this.Width, this.Height));

      SolidBrush sb = new SolidBrush(ForceSensorSettings.textColor);
      formGraphics.DrawString(Convert.ToInt32(value).ToString(), this.Font, sb, 4.0f, 2.0f);

      sb.Dispose();
      myBrush.Dispose();
      formGraphics.Dispose(); */
    }

    private Color getColor(int v)
    {
      SortedDictionary<int, Color> d = new SortedDictionary<int, Color>
      {
        { Convert.ToInt32(0), Color.Green },
        { Convert.ToInt32(0.25 * ForceSensorSettings.MAX_FORCE), Color.DarkGreen },
        { Convert.ToInt32(0.5 * ForceSensorSettings.MAX_FORCE), Color.Yellow },
        { Convert.ToInt32(0.75 * ForceSensorSettings.MAX_FORCE), Color.Orange },
        { Convert.ToInt32(ForceSensorSettings.MAX_FORCE), Color.Red }
      };
      KeyValuePair<int, Color> kvp_previous = new KeyValuePair<int, Color>(-1, Color.Black);
      foreach (KeyValuePair<int, Color> kvp in d)
      {
        if (kvp.Key > v)
        {
          double p = (v - kvp_previous.Key) / (double)(kvp.Key - kvp_previous.Key);
          Color a = kvp_previous.Value;
          Color b = kvp.Value;
          Color c = Color.FromArgb(
              Interpolate(a.R, b.R, p),
              Interpolate(a.G, b.G, p),
              Interpolate(a.B, b.B, p));
          return c;
        }
        kvp_previous = kvp;
      }
      return Color.Black;
    }
  }
  
  public static class ForceSensorSettings
  {
    public static float MIN_FORCE = 0f;
    public static float MAX_FORCE = 100f;
    public static Color textColor = Color.White;
  }
}
