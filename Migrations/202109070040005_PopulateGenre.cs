namespace vidlyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres values ('Comedy')");
            Sql("insert into Genres values ('Action')");
            Sql("insert into Genres values ('Family')");
            Sql("insert into Genres values ('Remance')");
        }

        public override void Down()
        {
        }
    }
}
