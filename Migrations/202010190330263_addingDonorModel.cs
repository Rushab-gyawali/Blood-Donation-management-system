namespace Blood_Donation_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingDonorModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonorModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonorName = c.String(nullable: false, maxLength: 255),
                        DonorAddress = c.String(),
                        Email = c.String(),
                        MobileNo = c.String(nullable: false),
                        TelephoneNo = c.String(),
                        PreviouslyDonatedDate = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        BloodGroup = c.String(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DonorModels");
        }
    }
}
