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
        Sun sun = null;
        Rain rain = null;
        Grass grass = null;

        int rowsCount = 0;
        int columnCount = 2;

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

            for(int row = 0; row < rowsCount; ++row)
            {
                new Cell(this, this.rainVisualControls, this.pictureBoxGrass, this.pictureBoxSkySun, this.columnCount, this.rowsCount);
            }

            /*rain = new Rain(rainVisualControls);
            sun = new island.Sun(pictureBoxSkySun);
            grass = new island.Grass(pictureBoxGrass);*/

            timer1.Interval = 1000;
            timer1.Start();
        }
     
        private void updateCell()
        {
            while (true)
            {
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rain.createRain(rnd.Next(0, 4));
            sun.createSun(rnd.Next(0, 4));
            grass.updateGrassStatus(rain.getRainState(), sun.getSunState());
        }
    }
}
