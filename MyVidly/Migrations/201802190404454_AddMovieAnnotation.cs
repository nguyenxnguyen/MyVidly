namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
