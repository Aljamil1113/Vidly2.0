namespace Vidly2_0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewRental : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewRentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Customer_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewRentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.NewRentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.NewRentals", new[] { "Movie_Id" });
            DropIndex("dbo.NewRentals", new[] { "Customer_Id" });
            DropTable("dbo.NewRentals");
        }
    }
}
