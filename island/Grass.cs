using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace island
{
    class Grass
    {
        enum GrassHeight
        {
            GrassHeightAbsent,
            GrassHeightVeryWeak,
            GrassHeightWeak,
            GrassHeightMiddle,
            GrassHeightHigh,
            GrassHeightVeryHigh
        }

        Color grassHeightAbsentColor = Color.Brown;
        Color grassHeightVeryWeakColor = Color.FromArgb(128, 255, 128);
        Color grassHeightWeakColor = Color.Lime;
        Color grassHeightMiddleColor = Color.FromArgb(0, 192, 0);
        Color grassHeightHighColor = Color.Green;
        Color grassHeightVeryHighColor = Color.FromArgb(0, 64, 0);

        int grassState = 0;

        bool isLakePresented = false;
        bool isMountainPresented = false;

        PictureBox pictureBoxGrass;

        public Grass(PictureBox pictureBox)
        {
            pictureBoxGrass = pictureBox;
        }

        public void setIsLakePresented(bool isLakePresented)
        {
            this.isLakePresented = isLakePresented;
        }

        public void setIsMountainPresented(bool isMountainPresented)
        {
            this.isMountainPresented = isMountainPresented;
        }

        public void createGrass(int strength)
        {
            grassState = strength;

            switch (strength)
            {
                case (int)GrassHeight.GrassHeightAbsent:
                    pictureBoxGrass.BackColor = grassHeightAbsentColor;
                    break;
                case (int)GrassHeight.GrassHeightVeryWeak:
                    pictureBoxGrass.BackColor = grassHeightVeryWeakColor;
                    break;
                case (int)GrassHeight.GrassHeightWeak:
                    pictureBoxGrass.BackColor = grassHeightMiddleColor;
                    break;
                case (int)GrassHeight.GrassHeightHigh:
                    pictureBoxGrass.BackColor = grassHeightHighColor;
                    break;
                case (int)GrassHeight.GrassHeightVeryHigh:
                    pictureBoxGrass.BackColor = grassHeightVeryHighColor;
                    break;
                default:
                    break;
            }
        }

        private void growGrassUp()
        {
            if (grassState < (int)GrassHeight.GrassHeightVeryHigh)
            {
                grassState++;
                createGrass(grassState);
            }
        }

        private void growGrassDown()
        {
            if (grassState > (int)GrassHeight.GrassHeightAbsent)
            {
                grassState--;
                createGrass(grassState);
            }
        }

        private void killGrass()
        {
            createGrass((int)GrassHeight.GrassHeightAbsent);
        }

        public void updateGrassStatus(int rainStatus, int sunStatus, bool mountainPresenseState, bool lakePresenceState)
        {
            if (isNeedGrowGrassUp(rainStatus, sunStatus))
            {
                growGrassUp();
            } else if (isNeedGrowGrassDown(rainStatus, sunStatus)) {
                growGrassDown();
            } else if (isNeedKillGrass(rainStatus, sunStatus)) {
                killGrass();
            }
        }

        public bool isNeedGrowGrassUp(int rainStatus, int sunStatus)
        {
            return (
                (((int)Rain.RainStrength.RainStrengthWeak == rainStatus) && ((int)Sun.SunStrength.SunStrengthWeak == sunStatus)) ||
                (((int)Rain.RainStrength.RainStrengthMiddle == rainStatus) && ((int)Sun.SunStrength.SunStrengthWeak == sunStatus)) ||
                 (((int)Rain.RainStrength.RainStrengthWeak == rainStatus) && ((int)Sun.SunStrength.SunStrengthMiddle == sunStatus)) ||
                (((int)Rain.RainStrength.RainStrengthMiddle == rainStatus) && ((int)Sun.SunStrength.SunStrengthMiddle == sunStatus)) ||
                (((int)Rain.RainStrength.RainStrengthHigh == rainStatus) && ((int)Sun.SunStrength.SunStrengthMiddle == sunStatus)) ||
                (((int)Rain.RainStrength.RainStrengthMiddle == rainStatus) && ((int)Sun.SunStrength.SunStrengthHigh == sunStatus)) ||
                (((int)Rain.RainStrength.RainStrengthHigh == rainStatus) && ((int)Sun.SunStrength.SunStrengthHigh == sunStatus))
            );

        }

        public bool isNeedGrowGrassDown(int rainStatus, int sunStatus)
        {
            return (((int)Rain.RainStrength.RainStrengthAbsent == rainStatus) && ((int)Sun.SunStrength.SunStrengthHigh == sunStatus));
        }

        public bool isNeedKillGrass(int rainStatus, int sunStatus)
        {
            return (((int)Rain.RainStrength.RainStrengthHigh == rainStatus) && ((int)Sun.SunStrength.SunStrengthAbsent == sunStatus));
        }
    }
}
