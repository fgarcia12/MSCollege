using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 namespace MSCLogica
{
  public static  class CM_Utilidades
    {
        
        public static void MensajeBox(String Mensaje, Boolean tipo=false)
        {
            String Titulo= "MSCollege";
            if (tipo)
            {
                MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
