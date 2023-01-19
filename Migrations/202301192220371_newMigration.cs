namespace WindowsEducacionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        IDCarrera = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IDCarrera);
            
            CreateTable(
                "dbo.Planes",
                c => new
                    {
                        IDPlan = c.Int(nullable: false, identity: true),
                        IDCarrera = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IDPlan)
                .ForeignKey("dbo.Carreras", t => t.IDCarrera, cascadeDelete: false)
                .Index(t => t.IDCarrera);
            
            CreateTable(
                "dbo.Planillas",
                c => new
                    {
                        IDPlanilla = c.Int(nullable: false, identity: true),
                        IDCarrera = c.Int(nullable: false),
                        IDMateria = c.Int(nullable: false),
                        IDProfesor = c.Int(nullable: false),
                        IDCurso = c.Int(nullable: false),
                        Fecha = c.DateTime(),
                    })
                .PrimaryKey(t => t.IDPlanilla)
                .ForeignKey("dbo.Carreras", t => t.IDCarrera, cascadeDelete: false)
                .ForeignKey("dbo.Cursos", t => t.IDCurso, cascadeDelete: false)
                .ForeignKey("dbo.Profesores", t => t.IDProfesor, cascadeDelete: false)
                .ForeignKey("dbo.Materias", t => t.IDMateria, cascadeDelete: false)
                .Index(t => t.IDCarrera)
                .Index(t => t.IDMateria)
                .Index(t => t.IDProfesor)
                .Index(t => t.IDCurso);
            
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        IDCurso = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IDCurso);
            
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        IDDetalle = c.Int(nullable: false, identity: true),
                        IDPlanilla = c.Int(nullable: false),
                        IDEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDDetalle)
                .ForeignKey("dbo.Estados", t => t.IDEstado, cascadeDelete: false)
                .ForeignKey("dbo.Planillas", t => t.IDPlanilla, cascadeDelete: false)
                .Index(t => t.IDPlanilla)
                .Index(t => t.IDEstado);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        IDEstado = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IDEstado);
            
            CreateTable(
                "dbo.Evaluaciones",
                c => new
                    {
                        IDEvaluacion = c.Int(nullable: false, identity: true),
                        IDTipo = c.Int(nullable: false),
                        IDEstudiante = c.Int(nullable: false),
                        IDDetalle = c.Int(nullable: false),
                        Nota = c.String(maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => t.IDEvaluacion)
                .ForeignKey("dbo.Detalles", t => t.IDDetalle, cascadeDelete: false)
                .ForeignKey("dbo.Estudiantes", t => t.IDEstudiante, cascadeDelete: false)
                .ForeignKey("dbo.Tipos", t => t.IDTipo, cascadeDelete: false)
                .Index(t => t.IDTipo)
                .Index(t => t.IDEstudiante)
                .Index(t => t.IDDetalle);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        IDEstudiante = c.Int(nullable: false, identity: true),
                        IDLocalidad = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 30, unicode: false),
                        Apellido = c.String(maxLength: 30, unicode: false),
                        Telefono = c.String(maxLength: 20, unicode: false),
                        Calle = c.String(maxLength: 20, unicode: false),
                        Numero = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.IDEstudiante)
                .ForeignKey("dbo.Localidades", t => t.IDLocalidad, cascadeDelete: false)
                .Index(t => t.IDLocalidad);
            
            CreateTable(
                "dbo.Localidades",
                c => new
                    {
                        IDLocalidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IDLocalidad);
            
            CreateTable(
                "dbo.Profesores",
                c => new
                    {
                        IDProfesor = c.Int(nullable: false, identity: true),
                        IDLocalidad = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 20, unicode: false),
                        Apellido = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IDProfesor)
                .ForeignKey("dbo.Localidades", t => t.IDLocalidad, cascadeDelete: false)
                .Index(t => t.IDLocalidad);
            
            CreateTable(
                "dbo.Tipos",
                c => new
                    {
                        IDTipo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IDTipo);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        IDMateria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.IDMateria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planillas", "IDMateria", "dbo.Materias");
            DropForeignKey("dbo.Detalles", "IDPlanilla", "dbo.Planillas");
            DropForeignKey("dbo.Evaluaciones", "IDTipo", "dbo.Tipos");
            DropForeignKey("dbo.Planillas", "IDProfesor", "dbo.Profesores");
            DropForeignKey("dbo.Profesores", "IDLocalidad", "dbo.Localidades");
            DropForeignKey("dbo.Estudiantes", "IDLocalidad", "dbo.Localidades");
            DropForeignKey("dbo.Evaluaciones", "IDEstudiante", "dbo.Estudiantes");
            DropForeignKey("dbo.Evaluaciones", "IDDetalle", "dbo.Detalles");
            DropForeignKey("dbo.Detalles", "IDEstado", "dbo.Estados");
            DropForeignKey("dbo.Planillas", "IDCurso", "dbo.Cursos");
            DropForeignKey("dbo.Planillas", "IDCarrera", "dbo.Carreras");
            DropForeignKey("dbo.Planes", "IDCarrera", "dbo.Carreras");
            DropIndex("dbo.Profesores", new[] { "IDLocalidad" });
            DropIndex("dbo.Estudiantes", new[] { "IDLocalidad" });
            DropIndex("dbo.Evaluaciones", new[] { "IDDetalle" });
            DropIndex("dbo.Evaluaciones", new[] { "IDEstudiante" });
            DropIndex("dbo.Evaluaciones", new[] { "IDTipo" });
            DropIndex("dbo.Detalles", new[] { "IDEstado" });
            DropIndex("dbo.Detalles", new[] { "IDPlanilla" });
            DropIndex("dbo.Planillas", new[] { "IDCurso" });
            DropIndex("dbo.Planillas", new[] { "IDProfesor" });
            DropIndex("dbo.Planillas", new[] { "IDMateria" });
            DropIndex("dbo.Planillas", new[] { "IDCarrera" });
            DropIndex("dbo.Planes", new[] { "IDCarrera" });
            DropTable("dbo.Materias");
            DropTable("dbo.Tipos");
            DropTable("dbo.Profesores");
            DropTable("dbo.Localidades");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Evaluaciones");
            DropTable("dbo.Estados");
            DropTable("dbo.Detalles");
            DropTable("dbo.Cursos");
            DropTable("dbo.Planillas");
            DropTable("dbo.Planes");
            DropTable("dbo.Carreras");
        }
    }
}
