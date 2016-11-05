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

            this.columnForCell = columnForCell;
            this.rowForCell = rowForCell;

            this.context = context;

            createRainVisualControls();
            createPictureBoxSkySun(pictureBoxSkySun);
            createPictureBoxGrass(pictureBoxGrass);

            this.rain = new Rain(this.rainVisualControls);
            this.sun = new island.Sun(this.pictureBoxSkySun);
            this.grass = new island.Grass(this.pictureBoxGrass);
        }

        public Rain getRain()
        {
            return this.rain;
        }

        public Sun getSun()
        {
            return this.sun;
        }

        public Grass getGrass()
        {
            return this.grass;
        }

        private void createRainVisualControls()
        {
            for (int indexForPictureBoxRainSource = 0; indexForPictureBoxRainSource < this.rainVisualControls.Length; ++indexForPictureBoxRainSource)
            {
                createRainVisualControl((PictureBox)this.rainVisualControls[indexForPictureBoxRainSource], indexForPictureBoxRainSource);
            }
        }

        private void createRainVisualControl(PictureBox pictureBoxRainSource, int indexForPictureBoxRainSource)
        {
            PictureBox pictureBoxRain = new PictureBox();

            pictureBoxRain.Size = pictureBoxRainSource.Size;
            pictureBoxRain.Image = pictureBoxRainSource.Image;
            pictureBoxRain.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRain.Location = new Point(pictureBoxRainSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + 10, pictureBoxRainSource.Location.Y);

            this.context.Controls.Add(pictureBoxRain);
            this.rainVisualControls[indexForPictureBoxRainSource] = pictureBoxRain;
        }

        private void createPictureBoxSkySun(PictureBox pictureBoxSkySunSource)
        {
            this.pictureBoxSkySun = new PictureBox();

            this.pictureBoxSkySun.Size = pictureBoxSkySunSource.Size;
            this.pictureBoxSkySun.BackColor = pictureBoxSkySunSource.BackColor;
            this.pictureBoxSkySun.Location = new Point(pictureBoxSkySunSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + 10, pictureBoxSkySunSource.Location.Y);

            this.context.Controls.Add(this.pictureBoxSkySun);
        }

        private void createPictureBoxGrass(PictureBox pictureBoxGrassSource)
        {
            this.pictureBoxGrass = new PictureBox();

            this.pictureBoxGrass.Size = pictureBoxGrassSource.Size;
            this.pictureBoxGrass.BackColor = pictureBoxGrassSource.BackColor;
            this.pictureBoxGrass.Location = new Point(pictureBoxGrassSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + 10, pictureBoxGrassSource.Location.Y);

            this.context.Controls.Add(this.pictureBoxGrass);
        }
    }
}
