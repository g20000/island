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
    public partial class FormModalDialogSkySun : Form
    {
        public event EventHandler<MyEventArgs> skySunLevelSelected;

        private int skySunLevel = -1;

        public FormModalDialogSkySun()
        {
            InitializeComponent();
        }

        private void FormModalDialogSkySun_Load(object sender, EventArgs e)
        {

        }

        private void onConfirmSelectionSkySunButtonTouched(object sender, EventArgs e)
        {
            this.skySunLevel = (this.skySunLevel != -1) ? this.skySunLevel : (int)Sun.SunStrength.SunStrengthAbsent;

            MyEventArgs args = new MyEventArgs();
            args.intArgumnent = this.skySunLevel;

            OnSkySunLevelSelected(args);
        }

        protected virtual void OnSkySunLevelSelected(MyEventArgs e)
        {
            skySunLevelSelected?.Invoke(this, e);
        }

        private void onRadioButtonSkySunLevelAbsentCheckedChanged(object sender, EventArgs e)
        {
            this.skySunLevel = (int)Sun.SunStrength.SunStrengthAbsent;
        }

        private void onRadioButtonSkySunLevelWeakCheckedChanged(object sender, EventArgs e)
        {
            this.skySunLevel = (int)Sun.SunStrength.SunStrengthWeak; 
        }

        private void onRadioButtonSkySunLevelMiddleCheckedChanged(object sender, EventArgs e)
        {
            this.skySunLevel = (int)Sun.SunStrength.SunStrengthMiddle; 
        }

        private void onRadioButtonSkySunLevelHighCheckedChanged(object sender, EventArgs e)
        {
            this.skySunLevel = (int)Sun.SunStrength.SunStrengthHigh;
        }
    }
}
