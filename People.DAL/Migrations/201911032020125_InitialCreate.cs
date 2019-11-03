namespace People.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Folks",
                c => new
                    {
                        PID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 240),
                        LastName = c.String(maxLength: 240),
                        Notes = c.String(maxLength: 2400),
                        Phone = c.String(maxLength: 240),
                        Email = c.String(maxLength: 240),
                        CrDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.PID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Folks");
        }
    }
}
