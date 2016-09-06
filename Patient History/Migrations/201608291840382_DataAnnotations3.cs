namespace Patient_History.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "PrimaryContacts", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Patients", "Complaints", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Complaints", c => c.String(maxLength: 100));
            AlterColumn("dbo.Patients", "PrimaryContacts", c => c.Long(nullable: false));
        }
    }
}
