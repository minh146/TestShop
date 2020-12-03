namespace TestShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class posttag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        PostID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.PostID, t.TagID })
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropTable("dbo.PostTags");
        }
    }
}
