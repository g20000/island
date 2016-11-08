using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace island
{
    class SquirrelPopulation
    {
        public enum SquirrelPopulationLevel
        {
            SquirrelPopulationLevelAbsent,
            SquirrelPopulationLevelWeak,
            SquirrelPopulationLevelMiddle,
            SquirrelPopulationLevelHigh
        }

        int squirrelPopulationState = 0;

        PictureBox pictureBoxSquirrel;
        PictureBox pictureBoxSquirrel2;
        PictureBox pictureBoxSquirrel3;

        public SquirrelPopulation(Object[] squirrelsVisualControls)
        {
            pictureBoxSquirrel = (PictureBox)squirrelsVisualControls[0];
            pictureBoxSquirrel2 = (PictureBox)squirrelsVisualControls[1];
            pictureBoxSquirrel3 = (PictureBox)squirrelsVisualControls[2];
        }

        public void createSquirrelPopulation(int populationLevel)
        {
            this.squirrelPopulationState = populationLevel;

            switch (populationLevel)
            {
                case (int)SquirrelPopulationLevel.SquirrelPopulationLevelAbsent:
                    createSquirrelPopulationAbsent();
                    break;
                case (int)SquirrelPopulationLevel.SquirrelPopulationLevelWeak:
                    createSquirrelPopulationWeak();
                    break;
                case (int)SquirrelPopulationLevel.SquirrelPopulationLevelMiddle:
                    createSquirrelPopulationMiddle();
                    break;
                case (int)SquirrelPopulationLevel.SquirrelPopulationLevelHigh:
                    createSquirrelPopulationHigh();
                    break;
                default:
                    break;
            }
        }

        public void increaseSquirrelPopulation()
        {
            if (getSquirrelPopulationState() < 3)
            {
                ++this.squirrelPopulationState;
            }
        }

        public void decreaseSquirrelPopulation()
        {
            if (getSquirrelPopulationState() > 0)
            {
                --this.squirrelPopulationState;
            }
        }

        private void createSquirrelPopulationAbsent()
        {
            this.pictureBoxSquirrel.Visible = false;
            this.pictureBoxSquirrel2.Visible = false;
            this.pictureBoxSquirrel3.Visible = false;
        }

        private void createSquirrelPopulationWeak()
        {
            this.pictureBoxSquirrel.Visible = true;
            this.pictureBoxSquirrel2.Visible = false;
            this.pictureBoxSquirrel3.Visible = false;
        }

        private void createSquirrelPopulationMiddle()
        {
            this.pictureBoxSquirrel.Visible = true;
            this.pictureBoxSquirrel2.Visible = true;
            this.pictureBoxSquirrel3.Visible = false;
        }

        private void createSquirrelPopulationHigh()
        {
            this.pictureBoxSquirrel.Visible = true;
            this.pictureBoxSquirrel2.Visible = true;
            this.pictureBoxSquirrel3.Visible = true;
        }

        public int getSquirrelPopulationState()
        {
            return this.squirrelPopulationState;
        }
    }
}
