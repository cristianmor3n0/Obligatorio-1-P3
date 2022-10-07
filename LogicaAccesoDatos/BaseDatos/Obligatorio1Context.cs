using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using LogicaNegocio.EntidadesDeNegocio;

namespace LogicaAccesoDatos.BaseDatos
{
    public class Obligatorio1Context:DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Seleccion> Selecciones { get; set; }
        public DbSet<ResultadoIncidencia> ResultadoIncidencias { get; set; }

        public Obligatorio1Context(DbContextOptions<Obligatorio1Context> opciones) : base(opciones)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
