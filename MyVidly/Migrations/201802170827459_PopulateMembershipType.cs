namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 1, 10, 10)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 3, 20, 15)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 6, 30, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
