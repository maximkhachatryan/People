namespace People.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 240),
                        LastName = c.String(maxLength: 240),
                        Notes = c.String(maxLength: 2400),
                        Phone = c.String(maxLength: 240),
                        Email = c.String(maxLength: 240),
                        CrDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PID)
                .Index(t => t.PID, clustered: true, name: "PK_Folks");
            Sql("ALTER TABLE dbo.People ADD CONSTRAINT DF_Folks_CrDate DEFAULT GETDATE() FOR CrDate");

        }
        
        public override void Down()
        {
            DropIndex("dbo.People", "PK_Folks");
            DropTable("dbo.People");
        }
    }
}
