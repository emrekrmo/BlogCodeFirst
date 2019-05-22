namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 400),
                        Content = c.String(unicode: false, storeType: "text"),
                        Date = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        ParentCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Categories", t => t.ParentCategoryId)
                .Index(t => t.ParentCategoryId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.TagArticles",
                c => new
                    {
                        Tag_TagId = c.Int(nullable: false),
                        Article_ArticleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_TagId, t.Article_ArticleId })
                .ForeignKey("dbo.Tags", t => t.Tag_TagId, cascadeDelete: true)
                .ForeignKey("dbo.Articles", t => t.Article_ArticleId, cascadeDelete: true)
                .Index(t => t.Tag_TagId)
                .Index(t => t.Article_ArticleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagArticles", "Article_ArticleId", "dbo.Articles");
            DropForeignKey("dbo.TagArticles", "Tag_TagId", "dbo.Tags");
            DropForeignKey("dbo.Articles", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories");
            DropIndex("dbo.TagArticles", new[] { "Article_ArticleId" });
            DropIndex("dbo.TagArticles", new[] { "Tag_TagId" });
            DropIndex("dbo.Categories", new[] { "ParentCategoryId" });
            DropIndex("dbo.Articles", new[] { "CategoryId" });
            DropTable("dbo.TagArticles");
            DropTable("dbo.Tags");
            DropTable("dbo.Categories");
            DropTable("dbo.Articles");
        }
    }
}
