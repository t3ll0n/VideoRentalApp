namespace VideoRentalWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriversLicenseAddPhoneToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "DrivingLicense");
        }
    }
}
