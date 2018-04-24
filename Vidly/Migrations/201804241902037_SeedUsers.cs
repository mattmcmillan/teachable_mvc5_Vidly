namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'50e5ff77-cec9-4637-bd5d-0702766ba695', N'admin@vidly.com', 0, N'AK6HsMLvUhOy0MDieBIX+dX1Brxwzn9hWMAhD1m1EfKi8mwnWaEPvJR6GhwCuCe+wg==', N'5cbb5dff-c81f-40d9-85aa-fd9935d7e4ca', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a1d5422e-bcb9-4217-95d2-aa0e87552556', N'mattmcmillanmedia@gmail.com', 0, N'ABVkpOzsK1PVLbBtL0bD0juMHs5t5ojMMwsdFYhvBMP9hyrAh3csHWCsJr2Er16SMQ==', N'997843bb-7662-411b-8328-796d7af22620', NULL, 0, 0, NULL, 1, 0, N'mattmcmillanmedia@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'af4c0a46-9987-4367-9127-3516d51aa85e', N'guest@vidly.com', 0, N'AOqzCN63Oxf0DxHoIuAKJz2U+wS6CYYn2UFS3uIbNEydgGArvu2eN6R7rR1xXztE9g==', N'4343f9d7-b059-41ec-8a72-97763734550f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c98f2f1a-a58f-4f82-bf59-e740c74af9ce', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'50e5ff77-cec9-4637-bd5d-0702766ba695', N'c98f2f1a-a58f-4f82-bf59-e740c74af9ce')
");
        }

        public override void Down()
        {
        }
    }
}
