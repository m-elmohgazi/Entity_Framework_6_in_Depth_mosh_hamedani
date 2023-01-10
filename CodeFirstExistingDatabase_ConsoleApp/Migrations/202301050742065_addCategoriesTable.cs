namespace CodeFirstExistingDatabase_ConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("insert into Categories (Name)values('web development')");
            Sql("insert into Categories (Name)values('programming languages')");
        }

        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
