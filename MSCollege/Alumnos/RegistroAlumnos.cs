using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MSCollege.Alumnos
{
    public partial class RegistroAlumnos : DevExpress.XtraEditors.XtraForm
    {
        public RegistroAlumnos()
        {
            InitializeComponent();
        }

        private void RegistroAlumnos_Load(object sender, EventArgs e)
        {
            cbfecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}