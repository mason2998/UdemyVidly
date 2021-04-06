namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvaible : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NUmberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
