namespace Vidly2_0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredReleasedDateMovie : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleasedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleasedDate", c => c.DateTime());
        }
    }
}
