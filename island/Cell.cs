using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace island
{
    
    class Cell
    {
        Object[] rainVisualControls = null;
        PictureBox pictureBoxRain = null;
        PictureBox pictureBoxRain1 = null;
        PictureBox pictureBoxRain2 = null;

        PictureBox pictureBoxSkySun = null;
        PictureBox pictureBoxGrass = null;

        Form context = null;

        Sun sun = null;
        Rain rain = null;
        Grass grass = null;

        int columnForCell = 0;
        int rowForCell = 0;

        public Cell(Form context, Object[] rainVisualControls, PictureBox pictureBoxGrass, PictureBox pictureBoxSkySun, int columnForCell, int rowForCell)
        {
            this.pictureBoxRain = (PictureBox)rainVisualControls[0];
            this.pictureBoxRain1 = (PictureBox)rainVisualControls[1];
            this.pictureBoxRain2 = (PictureBox)rainVisualControls[2];

            this.rainVisualControls = new Object[]{
                this.pictureBoxRain,
                this.pictureBoxRain1,
                this.pictureBoxRain2
            };

            this.pictureBoxGrass = pictureBoxGrass;
            this.pictureBoxSkySun = pictureBoxSkySun;

            this.context = context;

            createRainVisualControls();

            this.rain = new Rain(this.rainVisualControls);
            this.sun = new island.Sun(this.pictureBoxSkySun);
            this.grass = new island.Grass(this.pictureBoxGrass);
        }

        private void createRainVisualControls()
        {
            foreach (PictureBox pictureBox in this.rainVisualControls)
            {
                createRainVisualControl(pictureBox);
            }
        }

        private void createRainVisualControl(PictureBox pictureBoxRainSource)
        {
            PictureBox pictureBoxRain = new PictureBox();

            pictureBoxRain.Size = pictureBoxRainSource.Size;
            pictureBoxRain.Image = pictureBoxRainSource.Image;
            pictureBoxRain.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRain.Location = new Point(pictureBoxRainSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + 10, pictureBoxRainSource.Location.Y);

            this.context.Controls.Add(pictureBoxRain);
        }

        private void createPictureBoxRain()
        {

        }

        private void createPictureBoxSkySun()
        {

        }

        private void createPictureBoxGrass()
        {

        }
    }
}
