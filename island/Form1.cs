﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace island
{
    public partial class Form1 : Form
    {
        Random rnd = null;
        Object[] rainVisualControls = null;
        Object[] squirrelsVisualControls = null;
        List<Cell> cells = new List<Cell>();

        private PictureBox selectedPictureBoxRain;
        private PictureBox selectedPictureBoxSquirrel;
        private PictureBox selectedPictureBoxGrass;
        private PictureBox selectedPictureBoxSkySun;

        int rowsCount = 1;
        int columnCount = 1;

        FormModalDialogRain formDialogRain = new FormModalDialogRain();
        FormModalDialogSquirrelPopulation formDialogSquirrelPopulation = new FormModalDialogSquirrelPopulation();
        FormModalDialogGrass formDialogGrass = new FormModalDialogGrass();
        FormModalDialogSkySun formModalSkySun = new FormModalDialogSkySun();

        public Form1()
        {
            InitializeComponent();

            formDialogRain.rainStrengthSelected += mainApplicationFormThresholdReached;
            this.formDialogSquirrelPopulation.squirrelPopulationLevelSelected += mainApplicationFormSquirrelPopulationSelected;
            this.formDialogGrass.grassLevelSelected += mainApplicationFormGrassLevelSelected;
            this.formModalSkySun.skySunLevelSelected += mainApplicationFormSkySunLevelSelected;

            rainVisualControls = new Object[]{
                pictureBoxRain,
                pictureBoxRain2,
                pictureBoxRain3
            };

            this.squirrelsVisualControls = new Object[]
            {
                this.pictureBoxSquirrel,
                this.pictureBoxSquirrel2,
                this.pictureBoxSquirrel3
            };

            this.rnd = new Random();

            initCells();

            timer1.Interval = 1000;
        }

        private void initCells()
        {
            for (int row = 0; row < this.rowsCount; ++row)
            {
                for (int column = 0; column < this.columnCount; ++column)
                {
                    cells.Add(new Cell(this, this.rainVisualControls, this.squirrelsVisualControls, this.pictureBoxGrass, this.pictureBoxSkySun, this.pictureBoxMountain, this.pictureBoxLake, column, row));
                }
            }

            hideCellPrototype();

            foreach (Cell cell in this.cells)
            {
                cell.createRainOrLake(rnd.Next(0, 3));
                cell.getRain().createRain(rnd.Next(0, 4));
                cell.getSquirrelPopulation().createSquirrelPopulation(rnd.Next(0, 4));
                cell.getSun().createSun(rnd.Next(0, 4));
                //cell.getGrass().createGrass((int)Grass.GrassHeight.GrassHeightAbsent);
                cell.getGrass().createGrass(rnd.Next(0, 4));
            }
        }
     
        private void updateCells()
        {
            hideCellPrototype();

            updateWheather();
            replaceSquirrels();
            updateGrass();
            replaceSquirrels();
        }

        private void updateWheather()
        {
            foreach (Cell cell in this.cells)
            {
                cell.createRainOrLake(rnd.Next(0, 3));
                cell.getRain().createRain(rnd.Next(0, 4));
                cell.getSun().createSun(rnd.Next(0, 4));
                cell.getGrass().updateGrassStatus(cell.getRain().getRainState(), cell.getSun().getSunState(), cell.isMountainPresented(), cell.isLakePresented());
            }
        }

        private void updateGrass()
        {
            foreach (Cell cell in this.cells)
            {
                cell.getGrass().updateGrassStatusWithSquirrelPopulation(cell.getSquirrelPopulation().getSquirrelPopulationState());
            }
        }

        private void reproductSqurrels()
        {
            foreach (Cell cell in this.cells)
            {
                if (cell.getSquirrelPopulation().getSquirrelPopulationState() == (int)SquirrelPopulation.SquirrelPopulationLevel.SquirrelPopulationLevelMiddle)
                {
                    cell.getSquirrelPopulation().createSquirrelPopulation((int)SquirrelPopulation.SquirrelPopulationLevel.SquirrelPopulationLevelHigh);
                }
            }
        }

        private void hideCellPrototype()
        {
            this.pictureBoxRain.Visible = false;
            this.pictureBoxRain2.Visible = false;
            this.pictureBoxRain3.Visible = false;

            this.pictureBoxGrass.Visible = false;
            this.pictureBoxSkySun.Visible = false;

            this.pictureBoxMountain.Visible = false;
            this.pictureBoxLake.Visible = false;

            this.pictureBoxSquirrel.Visible = false;
            this.pictureBoxSquirrel2.Visible = false;
            this.pictureBoxSquirrel3.Visible = false;
        }

        private bool isDecreasePopulationNeeded(Cell cell)
        {
            return ((cell.getGrass().getGrassState() - cell.getSquirrelPopulation().getSquirrelPopulationState()) < 0);
        }

        private bool isIncreasePopulationAvailable(Cell cell)
        {
            return ((cell.getGrass().getGrassState() - cell.getSquirrelPopulation().getSquirrelPopulationState()) > 0);
        }

        private void replaceSquirrels()
        {
            foreach(Cell cell in this.cells)
            {
                while (isDecreasePopulationNeeded(cell))
                {
                    Cell[] nearSelectedCellArray = getNearCellWithFreeSpaceForSquirrel(cell);
                    if (nearSelectedCellArray.Length > 0)
                    {
                        Cell nearSelectedCell = nearSelectedCellArray.First<Cell>();

                        nearSelectedCell.getSquirrelPopulation().increaseSquirrelPopulation();
                        cell.getSquirrelPopulation().decreaseSquirrelPopulation();
                    } else
                    {
                        cell.getSquirrelPopulation().decreaseSquirrelPopulation();
                    }
                }
            }
        }

        private Cell[] getNearCellWithFreeSpaceForSquirrel(Cell cellSource)
        {
            foreach(Cell cell in this.cells)
            {
                if (isCellNearAbove(cellSource, cell))
                {
                    if (isIncreasePopulationAvailable(cell))
                    {
                        return new Cell[] { cell };
                    }
                }

                if (isCellNearRightAndLeft(cellSource, cell))
                {
                    if (isIncreasePopulationAvailable(cell))
                    {
                        return new Cell[] { cell };
                    }
                }

                if (isCellNearBottom(cellSource, cell))
                {
                    if (isIncreasePopulationAvailable(cell))
                    {
                        return new Cell[] { cell };
                    }
                }             
            }

            return new Cell[] { };
        }

        private bool isCellNearAbove(Cell cellSource, Cell cellDestionation)
        {
            return (
                        (((cellDestionation.getRowForCell() - 1) >= 0) && (cellDestionation.getRowForCell() == (cellSource.getRowForCell() - 1))) &&
                        (((cellDestionation.getColumnForCell() - 1) >= 0) && (cellDestionation.getColumnForCell() < this.columnCount) && ((cellDestionation.getColumnForCell() - 1) == cellSource.getColumnForCell()))
                   );
        }

        private bool isCellNearRightAndLeft(Cell cellSource, Cell cellDestionation)
        {
            return (
                        (cellDestionation.getRowForCell() == cellSource.getRowForCell()) &&
                        (((cellDestionation.getColumnForCell() - 1) >= 0) && (cellDestionation.getColumnForCell() < this.columnCount) && ((cellDestionation.getColumnForCell() - 1) == cellSource.getColumnForCell())) &&
                        (cellDestionation.getColumnForCell() != cellSource.getColumnForCell())
                   );
        }

        private bool isCellNearBottom(Cell cellSource, Cell cellDestionation)
        {
            return (
                        (((cellDestionation.getRowForCell() + 1) > this.rowsCount) && (cellDestionation.getRowForCell() == (cellSource.getRowForCell() + 1))) &&
                        (((cellDestionation.getColumnForCell() - 1) >= 0) && (cellDestionation.getColumnForCell() < this.columnCount) && ((cellDestionation.getColumnForCell() - 1) == cellSource.getColumnForCell()))
                   );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateCells();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void onStopClickedButtonTouched(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void onUpdateCellsOnceButtonTouched(object sender, EventArgs e)
        {
            updateCells();
        }

        private void pictureBoxLake_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.ShowDialog(this);
        }

        private void onSetRowsAndColumnsButtonTouched(object sender, EventArgs e)
        {
            
            this.columnCount = (!string.IsNullOrWhiteSpace(this.textBoxColumns.Text)) ? Int32.Parse(this.textBoxColumns.Text) : 1;
            this.rowsCount = (!string.IsNullOrWhiteSpace(this.textBoxRows.Text)) ? Int32.Parse(this.textBoxRows.Text) : 1;

            

            foreach (Cell cell in this.cells)
            {
                cell.clearControls();
            }


            this.cells.Clear();

            initCells();
        }

        private Cell cellContainsSenderPictureBoxRain(PictureBox pictureBoxRain)
        {
            foreach(Cell cell in this.cells)
            {
                Object[] rainVisualControls = cell.getRainVisualControls();

                foreach(Object rainVisualControl in rainVisualControls)
                {
                    if(rainVisualControl == pictureBoxRain)
                    {
                        return cell;
                    }
                }
            }

            return null;
        }

        private Cell cellContainsSenderPictureBoxSquirrel(PictureBox pictureBoxSquirrel)
        {
            foreach (Cell cell in this.cells)
            {
                Object[] squirrelVisualControls = cell.getSquirrelVisualControls();

                foreach (Object squirrelVisualControl in squirrelVisualControls)
                {
                    if (squirrelVisualControl == pictureBoxSquirrel)
                    {
                        return cell;
                    }
                }
            }

            return null;
        }

        private Cell cellContainsSenderPictureBoxGrass(PictureBox pictureBoxGrass)
        {
            foreach (Cell cell in this.cells)
            {
                PictureBox pictureBoxSelectedGrass = cell.getPictureBoxGrass();

                if (pictureBoxSelectedGrass == pictureBoxGrass)
                {
                    return cell;
                }
            }

            return null;
        }

        private Cell cellContainsSenderPictureBoxSkySun(PictureBox pictureBoxSkySun)
        {
            foreach (Cell cell in this.cells)
            {
                PictureBox pictureBoxSelectedSkySun = cell.getPictureBoxSkySun();

                if (pictureBoxSelectedSkySun == pictureBoxSkySun)
                {
                    return cell;
                }
            }

            return null;
        }

        public void mainApplicationFormThresholdReached(object sender, MyEventArgs e)
        {
            Cell cellWithSenderPictureBoxRain = cellContainsSenderPictureBoxRain(this.selectedPictureBoxRain);
            cellWithSenderPictureBoxRain.getRain().createRain(e.intArgumnent);

            this.formDialogRain.Close();
        }

        public void mainApplicationFormSquirrelPopulationSelected(object sender, MyEventArgs e)
        {
            Cell cellWithSenderPictureBoxSquirrel = cellContainsSenderPictureBoxSquirrel(this.selectedPictureBoxSquirrel);
            cellWithSenderPictureBoxSquirrel.getSquirrelPopulation().createSquirrelPopulation(e.intArgumnent);

            this.formDialogSquirrelPopulation.Close();
        }

        public void mainApplicationFormGrassLevelSelected(object sender, MyEventArgs e)
        {
            Cell cellWithSenderPictureBoxGrass = cellContainsSenderPictureBoxGrass(this.selectedPictureBoxGrass);
            cellWithSenderPictureBoxGrass.getGrass().createGrass(e.intArgumnent);

            this.formDialogGrass.Close();
        }

        public void mainApplicationFormSkySunLevelSelected(object sender, MyEventArgs e)
        {
            Cell cellWithSenderPictureBoxSkySun = cellContainsSenderPictureBoxSkySun(this.selectedPictureBoxSkySun);
            cellWithSenderPictureBoxSkySun.getSun().createSun(e.intArgumnent);

            this.formModalSkySun.Close();
        }

        private void onSetRainButtonTouched(object sender, EventArgs e)
        {
            this.selectedPictureBoxRain = (PictureBox)sender;

            formDialogRain.ShowDialog(this);
        }

        private void onSetSunStrengthButtonTouched(object sender, EventArgs e)
        {
            this.selectedPictureBoxSkySun = (PictureBox)sender;

            this.formModalSkySun.ShowDialog(this);
        }

        private void onSetGrassStrengthButtonTouched(object sender, EventArgs e)
        {
            this.selectedPictureBoxGrass = (PictureBox)sender;

            formDialogGrass.ShowDialog(this);
        }

        private void onSetMountainButtonTouched(object sender, EventArgs e)
        {
            
        }

        private void onSetSquirrelPopulationButtonTouched(object sender, EventArgs e)
        {
            this.selectedPictureBoxSquirrel = (PictureBox)sender;

            this.formDialogSquirrelPopulation.ShowDialog(this);
        }
    }
}
