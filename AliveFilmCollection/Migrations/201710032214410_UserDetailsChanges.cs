namespace AliveFilmCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDetailsChanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserDetails", "DateOfBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDetails", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
