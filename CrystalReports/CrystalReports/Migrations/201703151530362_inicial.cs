namespace CrystalReports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        pkProducto = c.Int(nullable: false, identity: true),
                        sNombreCorto = c.String(nullable: false, maxLength: 150),
                        sDescripcion = c.String(nullable: false, maxLength: 150),
                        sClasificacion = c.String(nullable: false, maxLength: 150),
                        dPrecio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dCosto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        iStock = c.Int(nullable: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkProducto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Permisos");
        }
    }
}
