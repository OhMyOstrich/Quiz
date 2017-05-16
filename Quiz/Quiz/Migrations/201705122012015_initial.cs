namespace Quiz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuizObjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        questiontext = c.String(),
                        QuizObject_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.QuizObjects", t => t.QuizObject_ID)
                .Index(t => t.QuizObject_ID);
            
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        answertext = c.String(),
                        isanswer = c.Boolean(nullable: false),
                        Question_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Questions", t => t.Question_ID)
                .Index(t => t.Question_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "QuizObject_ID", "dbo.QuizObjects");
            DropForeignKey("dbo.Answers", "Question_ID", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "Question_ID" });
            DropIndex("dbo.Questions", new[] { "QuizObject_ID" });
            DropTable("dbo.Answers");
            DropTable("dbo.Questions");
            DropTable("dbo.QuizObjects");
        }
    }
}
