using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LogicaNegocio.EntidadesDeNegocio
{
    public class Partido:IValidable
    {
        public IEnumerable<Seleccion> Selecciones { get; set; }
        public DateTime Fecha { get; set; }
        public string Grupo { get; set; }
        public ResultadoIncidencia ResultadoIncidencias { get; set; }
    }
}
