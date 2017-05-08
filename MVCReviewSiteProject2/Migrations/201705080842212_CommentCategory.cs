namespace MVCReviewSiteProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "Comment", c => c.String());

        }

        public override void Down()
        {
            AddColumn("dbo.Category", "Comment", c => c.String());

        }
    }
}
