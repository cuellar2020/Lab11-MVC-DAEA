namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCustomerSellerInvoiceDetailClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        subTitle = c.String(),
                        datetime = c.String(),
                        type = c.String(),
                        description = c.String(),
                        amount = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.SellerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sellers");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Customers");
        }
    }
}
