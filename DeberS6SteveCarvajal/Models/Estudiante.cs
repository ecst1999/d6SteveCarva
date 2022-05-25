using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberS6SteveCarvajal.Models
{    
    class Estudiante
    {
        public string Identificacion { get; set; }

        public string Nombres { get; set; }

        public string[] FechaAsistencia { get; set; }

        public Estudiante (string _identificacion, string _nombres)
        {
            this.Identificacion = _identificacion;

            this.Nombres = _nombres;
        }

        public void registarAsistencia()
        {
            string fecha = DateTime.Now.ToString();
            this.FechaAsistencia = new string[] { fecha };
        }
    }
}
