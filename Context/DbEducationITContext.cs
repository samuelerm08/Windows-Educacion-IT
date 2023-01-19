﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEducacionIT.Entidades;

namespace WindowsEducacionIT.Context
{
    public class DbEducationITContext : DbContext
    {
        //Database Key Name
        public DbEducationITContext() : base("dbKey") { }

        //DbSets
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Planilla> Planillas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
    }
}
