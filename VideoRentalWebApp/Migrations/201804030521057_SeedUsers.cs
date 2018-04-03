namespace VideoRentalWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'78f5ea26-71fb-48f2-9ef9-91c6b9f26a0b', N'guest@svr.com', 0, N'AOqSun1V69asDo3Ums9i+ZRDXUjz4wDprzdqzdwdfbE10q8hUpad7sZVQSMYBAnfYw==', N'6e8e778e-4e66-4fe2-973c-c8b3ae39cd1c', NULL, 0, 0, NULL, 1, 0, N'guest@svr.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a1d5537-1a0f-4c2d-81f5-7be2d1df3b00', N'admin@svr.com', 0, N'AJx8DaIuY7yn3isbUgZpNZBpg81Jp/rEFk/iL1mYFg8YPjiQNJIbZvSEhHLAyrEBnA==', N'8d855cb7-44e3-4163-9c6f-29fc45846ff2', NULL, 0, 0, NULL, 1, 0, N'admin@svr.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0248c521-4f6f-4da2-9c98-c0b1d3e77ab0', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a1d5537-1a0f-4c2d-81f5-7be2d1df3b00', N'0248c521-4f6f-4da2-9c98-c0b1d3e77ab0')
");
        }
        
        public override void Down()
        {
        }
    }
}
