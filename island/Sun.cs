using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace island
{
    class Sun
    {
        public enum SunStrength
        {
            SunStrengthAbsent,
            SunStrengthWeak,
            SunStrengthMiddle,
            SunStrengthHigh
        }

        int sunState = 0;

        PictureBox pictureBoxSkySun;

        Color sunStrengthAbsentColor = Color.Blue;
        Color sunStrengthWeakColor = Color.FromArgb(255, 255, 192);
        Color sunStrengthMiddleColor = Color.FromArgb(255, 255, 128);
        Color sunStrengthHighColor = Color.Yellow;

        public Sun(PictureBox pictureBox)
        {
            pictureBoxSkySun = pictureBox;
        }

        public void createSun(int strength)
        {
            sunState = strength;

            switch (strength)
            {
                case (int)SunStrength.SunStrengthAbsent:
                    pictureBoxSkySun.BackColor = sunStrengthAbsentColor;
                    break;
                case (int)SunStrength.SunStrengthWeak:
                    pictureBoxSkySun.BackColor = sunStrengthWeakColor;
                    break;
                case (int)SunStrength.SunStrengthMiddle:
                    pictureBoxSkySun.BackColor = sunStrengthMiddleColor;
                    break;
                case (int)SunStrength.SunStrengthHigh:
                    pictureBoxSkySun.BackColor = sunStrengthHighColor;
                    break;
                default:
                    break;
            }
        }

        public int getSunState()
        {
            return sunState;
        }
    }
}
