namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class puserseed : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'48413e92-38d4-4988-85ee-b5f2bde571b6', N'Sanchet@vidly.gmail.com', 0, N'AOv0TTP/hIWlb2ny3efgRuR+mLsGEWh+Xc7L1h+eCNIKMLp2e6otDC0N7rXdVAOy9Q==', N'e2bf6884-39bf-48f1-b1bc-5a44536c9395', NULL, 0, 0, NULL, 1, 0, N'Sanchet@vidly.gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ce8794f9-efbd-43ba-b2cf-6607498bc27a', N'admin@vidly.com', 0, N'ADhx3FKz30vYNm3upNfvg3zxXFBMgpMoCjbRaZ7birYqyvAauva+caA2dGZYcwtrig==', N'edf6f386-74ba-4c55-8172-88d5573a8578', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e9d7ecfc-3223-4f42-b00c-309f2805667c', N'CanMangeMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'48413e92-38d4-4988-85ee-b5f2bde571b6', N'e9d7ecfc-3223-4f42-b00c-309f2805667c')
");
        }

        public override void Down()
        {
        }
    }
}
