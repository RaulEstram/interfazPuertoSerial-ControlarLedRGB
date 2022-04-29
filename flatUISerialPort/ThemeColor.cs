using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flatUISerialPort
{
    public static class ThemeColor
    {
        public static Color primatyColor { get; set; }
        public static Color secondColor { get; set; }
        public static List<string> colors = new List<string>() {
            "#581845",
            "#C70039",
            "#FF5733",
            "#FFC300",
            "#DAF7A6"
        };

        public static Color cambiarBrilloColor(Color color, double correctionFactor) { 
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}










