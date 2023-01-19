namespace WindowsEducacionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewOneMig : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Carreras", newName: "Carrera");
            RenameTable(name: "dbo.Planes", newName: "Plan");
            RenameTable(name: "dbo.Planillas", newName: "Planilla");
            RenameTable(name: "dbo.Cursos", newName: "Curso");
            RenameTable(name: "dbo.Detalles", newName: "Detalle");
            RenameTable(name: "dbo.Estados", newName: "Estado");
            RenameTable(name: "dbo.Evaluaciones", newName: "Evaluacion");
            RenameTable(name: "dbo.Estudiantes", newName: "Estudiante");
            RenameTable(name: "dbo.Localidades", newName: "Localidad");
            RenameTable(name: "dbo.Profesores", newName: "Profesor");
            RenameTable(name: "dbo.Tipos", newName: "Tipo");
            RenameTable(name: "dbo.Materias", newName: "Materia");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Materia", newName: "Materias");
            RenameTable(name: "dbo.Tipo", newName: "Tipos");
            RenameTable(name: "dbo.Profesor", newName: "Profesores");
            RenameTable(name: "dbo.Localidad", newName: "Localidades");
            RenameTable(name: "dbo.Estudiante", newName: "Estudiantes");
            RenameTable(name: "dbo.Evaluacion", newName: "Evaluaciones");
            RenameTable(name: "dbo.Estado", newName: "Estados");
            RenameTable(name: "dbo.Detalle", newName: "Detalles");
            RenameTable(name: "dbo.Curso", newName: "Cursos");
            RenameTable(name: "dbo.Planilla", newName: "Planillas");
            RenameTable(name: "dbo.Plan", newName: "Planes");
            RenameTable(name: "dbo.Carrera", newName: "Carreras");
        }
    }
}
