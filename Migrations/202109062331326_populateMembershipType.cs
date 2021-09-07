namespace vidlyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("insert into  MemberShipTypes values (0,0,0)");
            Sql("insert into  MemberShipTypes values (30,1,10)");
            Sql("insert into  MemberShipTypes values (90,3,15)");
            Sql("insert into  MemberShipTypes values (300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
