using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace island
{
    class Rain
    {
        public enum RainStrength
        {
            RainStrengthAbsent,
            RainStrengthWeak,
            RainStrengthMiddle,
            RainStrengthHigh
        }

        int rainState = 0;
        PictureBox pictureBoxRain;
        PictureBox pictureBoxRain2;
        PictureBox pictureBoxRain3;

        public Rain(Object[] rainVisualControls)
        {
            pictureBoxRain = (PictureBox)rainVisualControls[0];
            pictureBoxRain2 = (PictureBox)rainVisualControls[1];
            pictureBoxRain3 = (PictureBox)rainVisualControls[2];
        }

        public void createRain(int strength)
        {
            rainState = strength;

            switch (strength)
            {
                case (int)RainStrength.RainStrengthAbsent:
                    createRainStrengthAbsent();
                    break;
                case (int)RainStrength.RainStrengthWeak:
                    createRainStrengthWeak();
                    break;
                case (int)RainStrength.RainStrengthMiddle:
                    createRainStrengthMiddle();
                    break;
                case (int)RainStrength.RainStrengthHigh:
                    createRainStrengthHigh();
                    break;
                default:
                    break;
            }
        }

        private void createRainStrengthAbsent()
        {
            pictureBoxRain.Visible = false;
            pictureBoxRain2.Visible = false;
            pictureBoxRain3.Visible = false;
        }

        private void createRainStrengthWeak()
        {
            pictureBoxRain.Visible = true;
            pictureBoxRain2.Visible = false;
            pictureBoxRain3.Visible = false;
        }

        private void createRainStrengthMiddle()
        {
            pictureBoxRain.Visible = true;
            pictureBoxRain2.Visible = true;
            pictureBoxRain3.Visible = false;
        }

        private void createRainStrengthHigh()
        {
            pictureBoxRain.Visible = true;
            pictureBoxRain2.Visible = true;
            pictureBoxRain3.Visible = true;
        }

        public int getRainState()
        {
            return rainState;
        }

        public void clearControls()
        {
            this.pictureBoxRain = null;
            this.pictureBoxRain2 = null;
            this.pictureBoxRain3 = null;
        }
    }
}
