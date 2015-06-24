using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace MSCollege.Alumnos
{
    public partial class RegAlumnos : DevExpress.XtraEditors.XtraForm
    {
        public RegAlumnos()
        {
            InitializeComponent();
        }



        private Herramientas.WebCam webcam;

        public MSCAccesoDatos.AlumnosDataContext dc = new MSCAccesoDatos.AlumnosDataContext();



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
            var s = new SaveFileDialog();
            var direccion = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Alumnos/" + carnetxt.Text;
            System.IO.Directory.CreateDirectory(direccion);
            s.FileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Alumnos/" + carnetxt.Text + "/foto.jpg";
            s.DefaultExt = ".jpg";
            s.Filter = "Image (.jpg)|*.jpg";

            var filename = s.FileName;
            var fstream = new FileStream(filename, FileMode.Create);
            pictureBox1.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();

            MessageBox.Show("Foto Guardada: /Alumnos/" + carnetxt.Text + "/");
            webcam.Stop();
        }





        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Valida.Validate())
            {
            }
        }
    }
}
