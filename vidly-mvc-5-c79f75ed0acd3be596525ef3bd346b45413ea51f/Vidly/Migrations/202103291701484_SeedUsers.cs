namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'20363f2d-e2ab-4434-b242-3d6bccf42766', N'admin@vidly.com', 0, N'ANY6ohTbOqjI1NKJyZBkeKddcOcunY248T5dktP69r9uXwZ29YtxNN7bLVu58yxQNA==', N'65a40df8-59b5-49b0-b782-dda3ea1985ac', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9411d0fd-759b-4766-bc2e-0886f31c4835', N'guest@vidly.com', 0, N'AK1AXL8vm2XHso/FU1qCUrf854wGwHz4wR6mgRN42keqrBdGn/dScl+XVLs8WUnR2g==', N'89a52112-0393-4ac2-a69a-48e919c19fa6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'02655420-9dd3-4e4f-8ed8-375f348c3707', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'20363f2d-e2ab-4434-b242-3d6bccf42766', N'02655420-9dd3-4e4f-8ed8-375f348c3707')
");
        }
        
        public override void Down()
        {
        }
    }
}
