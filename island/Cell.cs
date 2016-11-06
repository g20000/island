﻿using System;
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
        public enum LandscapeElement
        {
            LandscapeElementMountain,
            LandscapeElementLake,
            LandscapeElementGrassOnly
        }

        private enum CellOffset
        {
            CellOffsetVertical = 0,
            CellOffsetHorizontal = 10
        }

        Object[] rainVisualControls = null;
        PictureBox pictureBoxRain = null;
        PictureBox pictureBoxRain1 = null;
        PictureBox pictureBoxRain2 = null;

        PictureBox pictureBoxSkySun = null;
        PictureBox pictureBoxGrass = null;
        PictureBox pictureBoxMountain = null;
        PictureBox pictureBoxLake = null;

        Form context = null;

        Sun sun = null;
        Rain rain = null;
        Grass grass = null;

        bool isNeedSetLakeOrMountain = true;

        int columnForCell = 0;
        int rowForCell = 0;

        public Cell(Form context, Object[] rainVisualControls, PictureBox pictureBoxGrass, PictureBox pictureBoxSkySun, PictureBox pictureBoxMountain, PictureBox pictureBoxLake, int columnForCell, int rowForCell)
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
            /*this.pictureBoxMountain = pictureBoxMountain;
            this.pictureBoxLake = pictureBoxLake;*/

            this.columnForCell = columnForCell;
            this.rowForCell = rowForCell;

            this.context = context;

            createPictureBoxMountain(pictureBoxMountain);
            createPictureBoxLake(pictureBoxLake);
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

        public bool isMountainPresented()
        {
            return this.pictureBoxMountain.Visible;
        }

        public bool isLakePresented()
        {
            return this.pictureBoxLake.Visible;
        }

        public void createRainOrLake(int landscapeElement)
        {
            if (!this.isNeedSetLakeOrMountain)
            {
                return;
            }

            switch (landscapeElement)
            {
                case (int)LandscapeElement.LandscapeElementMountain:
                    createMountain();
                    break;
                case (int)LandscapeElement.LandscapeElementLake:
                    createLake();
                    break;
                case (int)LandscapeElement.LandscapeElementGrassOnly:
                    createGrassOnly();
                    break;
                default:
                    break;
            }
        }

        private void createMountain()
        {
            this.pictureBoxMountain.Visible = true;
            this.pictureBoxLake.Visible = false;

            this.isNeedSetLakeOrMountain = false;
        }

        private void createLake()
        {
            this.pictureBoxLake.Visible = true;
            this.pictureBoxMountain.Visible = false;

            this.isNeedSetLakeOrMountain = false;
        }

        private void createGrassOnly()
        {
            this.pictureBoxLake.Visible = false;
            this.pictureBoxMountain.Visible = false;

            this.isNeedSetLakeOrMountain = false;
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

            int offsetHorizontal = pictureBoxRainSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + (int)CellOffset.CellOffsetHorizontal;
            int offsetVertical = pictureBoxRainSource.Location.Y + (this.pictureBoxSkySun.Size.Height + this.pictureBoxGrass.Size.Height) * rowForCell + (int)CellOffset.CellOffsetVertical;
            
            pictureBoxRain.Location = new Point(offsetHorizontal, offsetVertical);

            this.context.Controls.Add(pictureBoxRain);
            this.rainVisualControls[indexForPictureBoxRainSource] = pictureBoxRain;
        }

        private void createPictureBoxSkySun(PictureBox pictureBoxSkySunSource)
        {
            this.pictureBoxSkySun = new PictureBox();

            this.pictureBoxSkySun.Size = pictureBoxSkySunSource.Size;
            this.pictureBoxSkySun.BackColor = pictureBoxSkySunSource.BackColor;

            int offsetHorizontal = pictureBoxSkySunSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + (int)CellOffset.CellOffsetHorizontal;
            int offsetVertical = pictureBoxSkySunSource.Location.Y + (this.pictureBoxSkySun.Size.Height + this.pictureBoxGrass.Size.Height) * rowForCell + (int)CellOffset.CellOffsetVertical;

            this.pictureBoxSkySun.Location = new Point(offsetHorizontal, offsetVertical);

            this.context.Controls.Add(this.pictureBoxSkySun);
        }

        private void createPictureBoxGrass(PictureBox pictureBoxGrassSource)
        {
            this.pictureBoxGrass = new PictureBox();

            this.pictureBoxGrass.Size = pictureBoxGrassSource.Size;
            this.pictureBoxGrass.BackColor = pictureBoxGrassSource.BackColor;

            int offsetHorizontal = pictureBoxGrassSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + (int)CellOffset.CellOffsetHorizontal;
            int offsetVertical = pictureBoxGrassSource.Location.Y + (this.pictureBoxSkySun.Size.Height + this.pictureBoxGrass.Size.Height) * rowForCell + (int)CellOffset.CellOffsetVertical;

            this.pictureBoxGrass.Location = new Point(offsetHorizontal, offsetVertical);

            this.context.Controls.Add(this.pictureBoxGrass);
        }

        private void createPictureBoxMountain(PictureBox pictureBoxMountainSource)
        {
            this.pictureBoxMountain = new PictureBox();

            pictureBoxMountain.Size = pictureBoxMountainSource.Size;
            pictureBoxMountain.Image = pictureBoxMountainSource.Image;
            pictureBoxMountain.SizeMode = PictureBoxSizeMode.Zoom;

            int offsetHorizontal = pictureBoxMountainSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + (int)CellOffset.CellOffsetHorizontal;
            int offsetVertical = pictureBoxMountainSource.Location.Y + (this.pictureBoxSkySun.Size.Height + this.pictureBoxGrass.Size.Height) * rowForCell + (int)CellOffset.CellOffsetVertical;

            this.pictureBoxMountain.Location = new Point(offsetHorizontal, offsetVertical);

            this.context.Controls.Add(this.pictureBoxMountain);
        }

        private void createPictureBoxLake(PictureBox pictureBoxLakeSource)
        {
            this.pictureBoxLake = new PictureBox();

            pictureBoxLake.Size = pictureBoxLakeSource.Size;
            pictureBoxLake.Image = pictureBoxLakeSource.Image;
            pictureBoxLake.SizeMode = PictureBoxSizeMode.Zoom;

            int offsetHorizontal = pictureBoxLakeSource.Location.X + this.pictureBoxGrass.Size.Width * columnForCell + (int)CellOffset.CellOffsetHorizontal;
            int offsetVertical = pictureBoxLakeSource.Location.Y + (this.pictureBoxSkySun.Size.Height + this.pictureBoxGrass.Size.Height) * rowForCell + (int)CellOffset.CellOffsetVertical;

            this.pictureBoxLake.Location = new Point(offsetHorizontal, offsetVertical);

            this.context.Controls.Add(this.pictureBoxLake);
        }
    }
}
