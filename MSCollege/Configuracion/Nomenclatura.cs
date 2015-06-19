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

namespace MSCollege.Configuracion
{
    public partial class Nomenclatura : DevExpress.XtraEditors.XtraForm
    {
        public Nomenclatura()
        {
            InitializeComponent();
            
        }

        class MyWrapper
        {
            private Control control;

            public MyWrapper(Control control)
            {
                this.control = control;
            }

            public Control Control
            {
                get { return control; }
            }
        }

        private void MyMouseDown(object sender, MouseEventArgs e)
        {
            Control source = (Control)sender;
            source.DoDragDrop(new MyWrapper(source), DragDropEffects.Move);
        }

       
        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(MyWrapper)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }


        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            MyWrapper wrapper = (MyWrapper)e.Data.GetData(typeof(MyWrapper));
            Control source = wrapper.Control;


            Point mousePosition = flowLayoutPanel1.PointToClient(new Point(e.X, e.Y));
            Control destination = flowLayoutPanel1.GetChildAtPoint(mousePosition);
            

            int indexDestination = flowLayoutPanel1.Controls.IndexOf(destination);
            if (flowLayoutPanel1.Controls.IndexOf(source) < indexDestination)
                indexDestination--;

            flowLayoutPanel1.Controls.SetChildIndex(source, indexDestination);

            cambiarstring();
        }

        public void cambiarstring()
        {

            labelControl2.Text = flowLayoutPanel1.Controls[0].Text +"-"+flowLayoutPanel1.Controls[1].Text +"-"+flowLayoutPanel1.Controls[2].Text;
            labelControl2.Focus();
            
        }

        private void Nomenclatura_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.MouseDown += MyMouseDown;
            }
        }

        private void simpleButton1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.MouseDown += MyMouseDown;
            }
        }

        private void simpleButton3_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.MouseDown += MyMouseDown;
            }
        }

       
    }
}