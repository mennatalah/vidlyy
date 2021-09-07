namespace vidlyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberTypeName1 : DbMigration
    {
        public override void Up()
        {
            Sql("update MemberShipTypes set MemberTypeName= 'Pay As Go' where id = 1");
            Sql("update MemberShipTypes set MemberTypeName= 'Monthly' where id = 2");
            Sql("update MemberShipTypes set MemberTypeName= 'Quarterly' where id = 3");
            Sql("update MemberShipTypes set MemberTypeName= 'Annual' where id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
