namespace PersonnelManagmentSystemV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201707211214378_Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CompName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.AspNetUsers", "Job_ID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Job_ID");
            AddForeignKey("dbo.AspNetUsers", "Job_ID", "dbo.Jobs", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Job_ID", "dbo.Jobs");
            DropIndex("dbo.AspNetUsers", new[] { "Job_ID" });
            DropColumn("dbo.AspNetUsers", "Job_ID");
            DropTable("dbo.Jobs");
        }
    }
}
