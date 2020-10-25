namespace Vidly2_0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedNameMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE  MembershipTypes SET Name = 'Pay As You Go' where Id = 1");
            Sql("UPDATE  MembershipTypes SET Name = 'Monthly' where Id = 2");
            Sql("UPDATE  MembershipTypes SET Name = 'Quarterly Year' where Id = 3");
            Sql("UPDATE  MembershipTypes SET Name = 'Yearly' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
