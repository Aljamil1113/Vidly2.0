namespace Vidly2_0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            //Sql(@"
            //INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'3e1c4a7a-d9cc-4349-a891-ba2abd34d674', N'guest@vidly.com', 0, N'AAOFOzpEBlfcjWSr3VnPbYKKPp77i8W7ojoFWAz66D4s8S2Izh8A4aQxOxMbsz9a7g==', N'55440211-e353-45ca-ac34-0cb6973f9da4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            //INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'8e3a05af-848c-4bea-88bd-88815bcdc009', N'admin@vidly.com', 0, N'AIz3kA1usBbGcM17Aiigw2dWogliMusNFfgOFURDFeBI+qZn8tPivdyRmlWcpIdtKA==', N'72a0bde5-6b3d-4723-9207-14edfd81e049', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
            //INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fa754bda-ca65-4c04-b03a-32231d8c25db', N'CanManageMovies')

            //INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8e3a05af-848c-4bea-88bd-88815bcdc009', N'fa754bda-ca65-4c04-b03a-32231d8c25db')

            //");
            
        }

        public override void Down()
        {
        }
    }
}
