namespace VideoRentalWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDurationInMonthsColumn : DbMigration
    {
        public override void Up()
        {
            Sql("sp_rename 'MembershipTypes.DurationInMnnths', 'DurationInMonths', 'COLUMN'");
        }
    }
}
