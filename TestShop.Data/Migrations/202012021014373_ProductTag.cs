namespace TestShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ProductTag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductTags",
                c => new
                {
                    ProductID = c.Int(nullable: false),
                    TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                })
                .PrimaryKey(t => new { t.ProductID, t.TagID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
        }

        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropTable("dbo.ProductTags");
        }
    }
}