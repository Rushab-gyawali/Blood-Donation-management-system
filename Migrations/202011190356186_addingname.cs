namespace Blood_Donation_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gender_Model", "Name_Name", c => c.String());
            CreateIndex("dbo.DonorModels", "GenderId");
            AddForeignKey("dbo.DonorModels", "GenderId", "dbo.Gender_Model", "Id", cascadeDelete: true);
            DropColumn("dbo.Gender_Model", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gender_Model", "Name", c => c.String());
            DropForeignKey("dbo.DonorModels", "GenderId", "dbo.Gender_Model");
            DropIndex("dbo.DonorModels", new[] { "GenderId" });
            DropColumn("dbo.Gender_Model", "Name_Name");
        }
    }
}
