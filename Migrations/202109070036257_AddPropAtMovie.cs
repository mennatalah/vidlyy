namespace vidlyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropAtMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DataRelase", c => c.DateTime());
            AddColumn("dbo.Movies", "DateAdd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateAdd");
            DropColumn("dbo.Movies", "DataRelase");
        }
    }
}
