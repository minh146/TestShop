namespace TestShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class All : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                {
                    ID = c.String(nullable: false, maxLength: 50, unicode: false),
                    Name = c.String(nullable: false, maxLength: 50),
                    Type = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.ID);

            CreateIndex("dbo.OrderDetails", "ProductID");
            CreateIndex("dbo.Products", "CategoryID");
            CreateIndex("dbo.Posts", "CategoryID");
            CreateIndex("dbo.PostTags", "TagID");
            CreateIndex("dbo.ProductTags", "TagID");
            AddForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories", "ID", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Posts", "CategoryID", "dbo.PostCategories", "ID", cascadeDelete: true);
            AddForeignKey("dbo.PostTags", "TagID", "dbo.Tags", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ProductTags", "TagID", "dbo.Tags", "ID", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.Posts", "CategoryID", "dbo.PostCategories");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.Posts", new[] { "CategoryID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropTable("dbo.Tags");
        }
    }
}