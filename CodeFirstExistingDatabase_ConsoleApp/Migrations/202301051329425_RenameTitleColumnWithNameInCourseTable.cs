namespace CodeFirstExistingDatabase_ConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleColumnWithNameInCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String());
            Sql("update Courses set Name = Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String());
            DropColumn("dbo.Courses", "Name");
        }
    }
}
