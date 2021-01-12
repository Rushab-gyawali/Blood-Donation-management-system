namespace Blood_Donation_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingGenderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gender_Model",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        GenderType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DonorModels", "GenderId", c => c.Byte(nullable: false));
            DropColumn("dbo.DonorModels", "Gender");
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Genders = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DonorModels", "Gender", c => c.String(nullable: false));
            DropColumn("dbo.DonorModels", "GenderId");
            DropTable("dbo.Gender_Model");
        }
    }
}
