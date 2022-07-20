namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDesignation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmployeeModels", "Designation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeModels", "Designation", c => c.String());
        }
    }
}
