namespace Patient_History.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Complaints : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Complaints", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "Complaints");
        }
    }
}
