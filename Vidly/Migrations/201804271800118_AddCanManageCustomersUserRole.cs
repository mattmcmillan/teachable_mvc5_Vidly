namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCanManageCustomersUserRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'62b9cdaa-ee2d-4bda-a2b4-380614f7aa91', N'CanManageCustomers')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'50e5ff77-cec9-4637-bd5d-0702766ba695', N'62b9cdaa-ee2d-4bda-a2b4-380614f7aa91')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
