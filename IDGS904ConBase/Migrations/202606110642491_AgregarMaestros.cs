namespace IDGS904ConBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarMaestros : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maestroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Carrera = c.String(maxLength: 100),
                        Telefono = c.String(maxLength: 100),
                        Edad = c.Int(nullable: false),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Maestroes");
        }
    }
}
