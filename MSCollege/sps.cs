using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace MSCollege
{
    public partial class sps : SplashScreen
    {
        public sps()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont == 10)
            {
                labelControl2.Text = "Cargando Modulos...";
            } 
            if (cont == 20)
            {
                labelControl2.Text = "Cargando db...";
            }
        }

        private void sps_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}