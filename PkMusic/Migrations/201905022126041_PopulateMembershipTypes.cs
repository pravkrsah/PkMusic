namespace PkMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,Name, SignUpFee,DurationInMonths,DiscountRate) VALUES (1,'Suman',0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id,Name, SignUpFee,DurationInMonths,DiscountRate) VALUES (2,'Rajan',20,1,10)");
            Sql("INSERT INTO MembershipTypes(Id,Name, SignUpFee,DurationInMonths,DiscountRate) VALUES (3,'Gaurab',60,3,15)");
            Sql("INSERT INTO MembershipTypes(Id,Name, SignUpFee,DurationInMonths,DiscountRate) VALUES (4,'Prabhakar',200,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
