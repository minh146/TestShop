namespace TestShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Slide1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Code = c.String(nullable: false, maxLength: 50, unicode: false),
                    ValueString = c.String(maxLength: 50),
                    ValueInt = c.Int(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                {
                    ID = c.Guid(nullable: false),
                    VisitedDate = c.DateTime(nullable: false),
                    IPAddress = c.String(maxLength: 50),
                })
                .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
        }
    }
}