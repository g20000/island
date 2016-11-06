using System;
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
        List<Cell> cells = new List<Cell>();

        int rowsCount = 3;
        int columnCount = 3;

        public Form1()
        {
            InitializeComponent();

            rainVisualControls = new Object[]{
                pictureBoxRain,
                pictureBoxRain2,
                pictureBoxRain3
            };

            rnd = new Random();

            for (int row = 0; row < rowsCount; ++row)
            {
                for (int column = 0; column < columnCount; ++column)
                {
                    cells.Add(new Cell(this, this.rainVisualControls, this.pictureBoxGrass, this.pictureBoxSkySun, this.pictureBoxMountain, this.pictureBoxLake, column, row));
                }
            }

            initCells();

            timer1.Interval = 1000;
        }

        private void initCells()
        {
            hideCellPrototype();

            foreach (Cell cell in this.cells)
            {
                cell.createRainOrLake(rnd.Next(0, 3));
                cell.getRain().createRain(rnd.Next(0, 4));
                cell.getSun().createSun(rnd.Next(0, 4));
                cell.getGrass().createGrass((int)Grass.GrassHeight.GrassHeightAbsent);
            }
        }
     
        private void updateCells()
        {
            hideCellPrototype();

            foreach (Cell cell in this.cells)
            {
                cell.createRainOrLake(rnd.Next(0, 3));
                cell.getRain().createRain(rnd.Next(0, 4));
                cell.getSun().createSun(rnd.Next(0, 4));
                cell.getGrass().updateGrassStatus(cell.getRain().getRainState(), cell.getSun().getSunState(), cell.isMountainPresented(), cell.isLakePresented());
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
    }
}
