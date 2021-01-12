namespace Blood_Donation_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updating : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Gender_Model", "Name_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gender_Model", "Name_Name", c => c.String());
        }
    }
}
