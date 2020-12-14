namespace TestShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class post : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 256),
                    Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                    CategoryID = c.Int(nullable: false),
                    Image = c.String(maxLength: 256),
                    Description = c.String(maxLength: 500),
                    Content = c.String(),
                    HomeFlag = c.Boolean(),
                    HotFlag = c.Boolean(),
                    ViewCount = c.Int(),
                    CreatedDate = c.DateTime(),
                    CreatedBy = c.String(maxLength: 256),
                    UpdatedDate = c.DateTime(),
                    UpdatedBy = c.String(maxLength: 256),
                    MetaKeyword = c.String(maxLength: 256),
                    MetaDescription = c.String(maxLength: 256),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}