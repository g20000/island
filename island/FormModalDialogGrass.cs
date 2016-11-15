using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace island
{
    public partial class FormModalDialogGrass : Form
    {
        public event EventHandler<MyEventArgs> grassLevelSelected;

        private int grassLevel = -1;

        public FormModalDialogGrass()
        {
            InitializeComponent();
        }

        private void FormModalDialogGrass_Load(object sender, EventArgs e)
        {

        }

        private void onConfirmSelectionGrassButtonTouched(object sender, EventArgs e)
        {
            this.grassLevel = (this.grassLevel != -1) ? this.grassLevel : (int)Grass.GrassHeight.GrassHeightAbsent;

            MyEventArgs args = new MyEventArgs();
            args.intArgumnent = this.grassLevel;

            OnGrassLevelSelected(args);
        }

        protected virtual void OnGrassLevelSelected(MyEventArgs e)
        {
            grassLevelSelected?.Invoke(this, e);
        }

        private void onRadioButtonGrassLevelAbsentCheckedChanged(object sender, EventArgs e)
        {
            this.grassLevel = (int)Grass.GrassHeight.GrassHeightAbsent;
        }

        private void onRadioButtonGrassLevelVeryWeakCheckedChanged(object sender, EventArgs e)
        {
            this.grassLevel = (int)Grass.GrassHeight.GrassHeightVeryWeak;
        }

        private void onRadioButtonGrassLevelWeakCheckedChanged(object sender, EventArgs e)
        {
            this.grassLevel = (int)Grass.GrassHeight.GrassHeightWeak;
        }

        private void onRadioButtonGrassLevelMiddleCheckedChanged(object sender, EventArgs e)
        {
            this.grassLevel = (int)Grass.GrassHeight.GrassHeightMiddle;
        }

        private void onRadioButtonGrassLevelStrongCheckedChanged(object sender, EventArgs e)
        {
            this.grassLevel = (int)Grass.GrassHeight.GrassHeightHigh;
        }

        private void onRadioButtonGrassLevelVeryStrongCheckedChanged(object sender, EventArgs e)
        {
            this.grassLevel = (int)Grass.GrassHeight.GrassHeightVeryHigh;
        }
    }
}
