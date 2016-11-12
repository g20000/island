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
    public partial class FormModalDialogRain : Form
    {
        public event EventHandler<MyEventArgs> rainStrengthSelected;

        private int rainStrength = -1;

        public FormModalDialogRain()
        {
            InitializeComponent();
        }

        private void FormModalDialogRain_Load(object sender, EventArgs e)
        {

        }

        private void onConfirmSelectionButtonTouched(object sender, EventArgs e)
        {
            this.rainStrength = (this.rainStrength != -1) ? this.rainStrength : (int)Rain.RainStrength.RainStrengthAbsent;

            MyEventArgs args = new MyEventArgs();
            args.intArgumnent = this.rainStrength;

            OnRainStrengthSelected(args);
        }

        protected virtual void OnRainStrengthSelected(MyEventArgs e)
        {
            rainStrengthSelected?.Invoke(this, e);
        }

        private void onRadioButtonRainAbsentCheckedChanged(object sender, EventArgs e)
        {
            this.rainStrength = (int)Rain.RainStrength.RainStrengthAbsent;
        }

        private void onRadioButtonRainWeakCheckedChanged(object sender, EventArgs e)
        {
            this.rainStrength = (int)Rain.RainStrength.RainStrengthWeak;
        }

        private void onRadioButtonRainMiddleCheckedChanged(object sender, EventArgs e)
        {
            this.rainStrength = (int)Rain.RainStrength.RainStrengthMiddle;
        }

        private void onRadioButtonRainStrongCheckedChanged(object sender, EventArgs e)
        {
            this.rainStrength = (int)Rain.RainStrength.RainStrengthHigh;
        }
    }
}
