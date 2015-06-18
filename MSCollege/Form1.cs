using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MSCollege
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1500);
            this.WindowState = FormWindowState.Maximized;
        }


        private void Catedraticos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            Catedraticos.Catedraticos ca = new Catedraticos.Catedraticos();
            ca.TopLevel = false;
            ca.Parent = this.MdiParent;
            ca.Dock = DockStyle.Fill;
            ca.Show();
            ca.BringToFront();
            PanelPrincipal.Controls.Add(ca);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            Alumnos.RegistroAlumnos ra = new Alumnos.RegistroAlumnos();
            ra.TopLevel = false;
            ra.Parent = this.MdiParent;
            ra.Dock = DockStyle.Fill;
            ra.Show();
            ra.BringToFront();
            PanelPrincipal.Controls.Add(ra);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            Configuracion.Nomenclatura ra = new Configuracion.Nomenclatura();
            ra.TopLevel = false;
            ra.Parent = this.MdiParent;
            ra.Dock = DockStyle.Fill;
            ra.Show();
            ra.BringToFront();
             PanelPrincipal.Controls.Add(ra);
        }
    }
}
