namespace Patient_History.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "PrimaryContacts", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "PrimaryContacts", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
