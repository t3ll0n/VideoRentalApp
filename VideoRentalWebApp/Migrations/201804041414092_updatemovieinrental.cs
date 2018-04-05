namespace VideoRentalWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemovieinrental : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Rentals", name: "Mo_Id", newName: "Movie_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_Mo_Id", newName: "IX_Movie_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Rentals", name: "IX_Movie_Id", newName: "IX_Mo_Id");
            RenameColumn(table: "dbo.Rentals", name: "Movie_Id", newName: "Mo_Id");
        }
    }
}
