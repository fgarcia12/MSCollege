﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSCComun;
using System.Windows.Forms;
using MSCLogica;

namespace MSCLogica
{

    public class LGAlumno
    {
        
     
        public  void ValidaAlumno(MSCComun.CMAlumno Alumno)
        {
           
            if (String.IsNullOrEmpty(Alumno.AL_CARNET1))
            {
                CM_Utilidades.MensajeBox("Carnet del alumno esta en blanco", true);
            }
            
        }

    }
}
