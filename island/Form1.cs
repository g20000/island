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
        Sun sun = null;
        Rain rain = null;
        Grass grass = null;

        int rowsCount = 0;
        int columnCount = 3;

        public Form1()
        {
            InitializeComponent();

            rainVisualControls = new Object[]{
                pictureBoxRain,
                pictureBoxRain2,
                pictureBoxRain3
            };

            //createCell();
            //updateCell();

            rnd = new Random();

            for(int column = 0; column < columnCount; ++column)
            {
                cells.Add(new Cell(this, this.rainVisualControls, this.pictureBoxGrass, this.pictureBoxSkySun, this.pictureBoxMountain, this.pictureBoxLake, column, this.rowsCount));
            }

            rain = new Rain(rainVisualControls);
            sun = new island.Sun(pictureBoxSkySun);
            grass = new island.Grass(pictureBoxGrass);

            timer1.Interval = 1000;
            timer1.Start();
        }
     
        private void updateCell()
        {
            while (true)
            {
                
            }
        }

        private void hideCellPrototype()
        {
            this.pictureBoxRain.Visible = false;
            this.pictureBoxRain2.Visible = false;
            this.pictureBoxRain3.Visible = false;

            this.pictureBoxGrass.Visible = false;
            this.pictureBoxSkySun.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hideCellPrototype();

            foreach(Cell cell in this.cells)
            {
                cell.createRainOrLake(rnd.Next(0, 2));
                cell.getRain().createRain(rnd.Next(0, 4));
                cell.getSun().createSun(rnd.Next(0, 4));
                cell.getGrass().updateGrassStatus(cell.getRain().getRainState(), cell.getSun().getSunState(), cell.isMountainPresented(), cell.isLakePresented());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
