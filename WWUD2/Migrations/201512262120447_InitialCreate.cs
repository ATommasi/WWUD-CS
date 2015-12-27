namespace WWUD2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        QuestionContent = c.String(nullable: false, maxLength: 180),
                    })
                .PrimaryKey(t => t.QuestionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questions");
        }
    }
}
