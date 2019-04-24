namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'8b84f57d-e28b-4ad3-970b-1be17dcb2fff', N'guest@vidly.com', 0, N'ALSU3hZy340wKbv2sLnBmcVGfO/DPGKUzvfS+gW5oNyxVy9eFzTfAmtJjO2Bsw6zog==', N'0987aa85-a30f-4cec-8d89-43e55d9d04aa', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'8cff2850-d6ca-4297-84f6-542fb3aff1d0', N'admin@vidly.com', 0, N'AIewMZRhF+W6TRTKJ/YttIkIdHR5MFqCJLIGqcTJKf+X0KfScHAjTFaP2krX5pOY1w==', N'8890df11-6e9e-4d4a-a2a2-0035c46dda94', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a998adc7-1fd2-4808-bad1-2122c4aa9953', N'CanManageMovies')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8cff2850-d6ca-4297-84f6-542fb3aff1d0', N'a998adc7-1fd2-4808-bad1-2122c4aa9953')");

        }

        public override void Down()
        {
        }
    }
}
