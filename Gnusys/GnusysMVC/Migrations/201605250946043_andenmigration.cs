namespace GnusysMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class andenmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeviceHistories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Device = c.String(),
                        User = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        User = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fornavn = c.String(),
                        Efternavn = c.String(),
                        User = c.Int(nullable: false),
                        CPR = c.String(),
                        Accesslevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserInfoes");
            DropTable("dbo.Devices");
            DropTable("dbo.DeviceHistories");
        }
    }
}
