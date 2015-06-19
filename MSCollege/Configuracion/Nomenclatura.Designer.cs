namespace MSCollege.Configuracion
{
    partial class Nomenclatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.asd = new DevExpress.XtraEditors.LabelControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.simpleButton2);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton1);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(148, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 149);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(3, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(181, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "22";
            this.simpleButton2.ToolTip = "Código Carrera";
            this.simpleButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simpleButton2_MouseDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(3, 32);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(181, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "2015";
            this.simpleButton1.ToolTip = "Año de Inscripción";
            this.simpleButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simpleButton1_MouseDown);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(3, 61);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(181, 23);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "0001";
            this.simpleButton3.ToolTip = "Correlativo";
            this.simpleButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simpleButton3_MouseDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Location = new System.Drawing.Point(138, 218);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ejemplo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Location = new System.Drawing.Point(226, 218);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "22-2015-0001";
            // 
            // asd
            // 
            this.asd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.asd.Location = new System.Drawing.Point(133, 24);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(217, 19);
            this.asd.TabIndex = 2;
            this.asd.Text = "Arrastra para cambiar el orden";
            // 
            // Nomenclatura
            // 
            this.ClientSize = new System.Drawing.Size(590, 411);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nomenclatura";
            this.Text = "New";
            this.Load += new System.EventHandler(this.Nomenclatura_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl asd;

    }
}