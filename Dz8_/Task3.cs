using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz8_
{
    struct RGB
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public string HEX()
        {
            string hexR = R.ToString("X2");
            string hexG = G.ToString("X2");
            string hexB = B.ToString("X2");
            return $"#{hexR}{hexG}{hexB}";
        }

        public void HSL(out double h, out double s, out double l)
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            double max = Math.Max(Math.Max(r, g), b);
            double min = Math.Min(Math.Min(r, g), b);

            double diff = max - min;
            double sum = max + min;

            h = 0;
            s = 0;
            l = sum / 2.0;

            if (max == min)
            {
                h = 0;
                s = 0;
            }
            else
            {
                s = diff / (l > 0.5 ? 2 - sum : sum);

                if (max == r)
                    h = (g - b) / diff + (g < b ? 6 : 0);
                else if (max == g)
                    h = (b - r) / diff + 2;
                else if (max == b)
                    h = (r - g) / diff + 4;

                h /= 6;
            }

            h *= 360;
        }

        public void CMYK(out double c, out double m, out double y, out double k)
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            k = 1 - Math.Max(Math.Max(r, g), b);
            c = (1 - r - k) / (1 - k);
            m = (1 - g - k) / (1 - k);
            y = (1 - b - k) / (1 - k);
        }
    }
}
