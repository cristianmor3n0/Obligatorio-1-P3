using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.EntidadesDeNegocio
{
    public class Seleccion
    {
        public Pais Pais { get; set; }
        public Grupo Grupo { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public int CantApostadores { get; set; }
    }
}
