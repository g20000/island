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
    public partial class FormModalDialogSquirrelPopulation : Form
    {
        public event EventHandler<MyEventArgs> squirrelPopulationLevelSelected;

        private int squirrelPopulationLevel = -1;

        public FormModalDialogSquirrelPopulation()
        {
            InitializeComponent();
        }

        private void FormModalDialogSquirrelPopulation_Load(object sender, EventArgs e)
        {

        }

        private void onConfirmSelectionButtonTouched(object sender, EventArgs e)
        {
            this.squirrelPopulationLevel = (this.squirrelPopulationLevel != -1) ? this.squirrelPopulationLevel : (int)SquirrelPopulation.SquirrelPopulationLevel.SquirrelPopulationLevelAbsent;

            MyEventArgs args = new MyEventArgs();
            args.intArgumnent = this.squirrelPopulationLevel;

            OnSquirrelLevelSelected(args);
        }

        protected virtual void OnSquirrelLevelSelected(MyEventArgs e)
        {
            squirrelPopulationLevelSelected?.Invoke(this, e);
        }

        private void onRadioButtonSquirrelPopulationAbsentCheckedChanged(object sender, EventArgs e)
        {
            this.squirrelPopulationLevel = (int)SquirrelPopulation.SquirrelPopulationLevel.SquirrelPopulationLevelAbsent;
        }

        private void onRadioButtonSquirrelPopulationWeakCheckedChanged(object sender, EventArgs e)
        {
            this.squirrelPopulationLevel = (int)SquirrelPopulation.SquirrelPopulationLevel.SquirrelPopulationLevelWeak;
        }

        private void onRadioButtonSquirrelPopulationMiddleCheckedChanged(object sender, EventArgs e)
        {
            this.squirrelPopulationLevel = (int)SquirrelPopulation.SquirrelPopulationLevel.SquirrelPopulationLevelMiddle;
        }

        private void onRadioButtonSquirrelPopulationStrongCheckedChanged(object sender, EventArgs e)
        {
            this.squirrelPopulationLevel = (int)SquirrelPopulation.SquirrelPopulationLevel.SquirrelPopulationLevelHigh;
        }
    }
}
