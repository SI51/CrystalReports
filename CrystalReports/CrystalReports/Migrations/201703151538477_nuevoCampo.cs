namespace CrystalReports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevoCampo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Permisos", "sDepartamento", c => c.String(nullable: false, maxLength: 150, storeType: "nvarchar"));
            DropColumn("dbo.Permisos", "sDescripcion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Permisos", "sDescripcion", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.Permisos", "sDepartamento");
        }
    }
}
