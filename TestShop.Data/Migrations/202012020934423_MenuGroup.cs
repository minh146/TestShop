﻿namespace TestShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MenuGroup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuGroups",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropTable("dbo.MenuGroups");
        }
    }
}