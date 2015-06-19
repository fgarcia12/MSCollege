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
using System.IO;
using WebCam_Capture;

namespace MSCollege.Alumnos
{
    public partial class RegAlumnos : DevExpress.XtraEditors.XtraForm
    {
        public RegAlumnos()
        {
            InitializeComponent();
        }

        Herramientas.WebCam webcam;
        private void button1_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void RegAlumnos_Load(object sender, EventArgs e)
        {
            webcam = new Herramientas.WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
            cbfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            string direccion = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Alumnos/" + carnetxt.Text;
            System.IO.Directory.CreateDirectory(direccion);
            s.FileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Alumnos/" + carnetxt.Text + "/foto.jpg";
            s.DefaultExt = ".jpg";
            s.Filter = "Image (.jpg)|*.jpg";
            // Save Image
            string filename = s.FileName;
            FileStream fstream = new FileStream(filename, FileMode.Create);
            pictureBox1.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();

            MessageBox.Show("Foto Guardada: /Alumnos/" + carnetxt.Text + "/");
            webcam.Stop();
        }
    }
}