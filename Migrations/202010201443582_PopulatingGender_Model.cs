namespace Blood_Donation_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingGender_Model : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Gender_Model (Id, GenderType) VALUES (1,'Male')");
            Sql("INSERT INTO Gender_Model (Id, GenderType) VALUES (2,'Female')");
            Sql("INSERT INTO Gender_Model (Id, GenderType) VALUES (3,'Other')");
        }
        
        public override void Down()
        {
        }
    }
}
