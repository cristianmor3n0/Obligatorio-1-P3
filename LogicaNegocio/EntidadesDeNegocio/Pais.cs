using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.EntidadesDeNegocio
{
    public class Pais
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public double Pbi { get; set; }
        public int Poblacion { get; set; }
        public string Imagen { get; set; }
        public Region Region { get; set; }
    }
}
