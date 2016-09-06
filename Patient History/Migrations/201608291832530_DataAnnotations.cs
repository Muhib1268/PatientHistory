namespace Patient_History.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "FirstName", c => c.String(maxLength: 60));
            AlterColumn("dbo.Patients", "LastName", c => c.String(maxLength: 60));
            AlterColumn("dbo.Patients", "Gender", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "Complaints", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Complaints", c => c.String());
            AlterColumn("dbo.Patients", "Gender", c => c.String());
            AlterColumn("dbo.Patients", "LastName", c => c.String());
            AlterColumn("dbo.Patients", "FirstName", c => c.String());
        }
    }
}
