namespace Vidly2_0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupulateMemberTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignUpFree, DurationInMonths, DiscountRate) VALUES(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFree, DurationInMonths, DiscountRate) VALUES(2,30,1,10)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFree, DurationInMonths, DiscountRate) VALUES(3,90,3,15)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFree, DurationInMonths, DiscountRate) VALUES(4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
