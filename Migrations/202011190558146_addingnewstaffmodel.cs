namespace Blood_Donation_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingnewstaffmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffName = c.String(),
                        StaffAddress = c.String(),
                        Email = c.String(),
                        MobileNo = c.String(),
                        DesignationId = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StaffModels");
        }
    }
}
