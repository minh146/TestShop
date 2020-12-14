namespace TestShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    CustomerName = c.String(nullable: false, maxLength: 256),
                    CustomerAddress = c.String(nullable: false, maxLength: 256),
                    CustomerEmail = c.String(nullable: false, maxLength: 256),
                    CustomerMobile = c.String(nullable: false, maxLength: 50),
                    CustomerMessage = c.String(nullable: false, maxLength: 256),
                    PaymentMethod = c.String(maxLength: 256),
                    CreatedDate = c.DateTime(),
                    CreatedBy = c.String(),
                    PaymentStatus = c.String(),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateIndex("dbo.Menus", "GroupID");
            AddForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups", "ID", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups");
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropTable("dbo.Orders");
        }
    }
}