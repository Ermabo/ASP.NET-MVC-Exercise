namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectedToQuarterlyAndAnnual : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes Set Name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
