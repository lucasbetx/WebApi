namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nova : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Endereco = c.String(unicode: false),
                        Telefone = c.String(unicode: false),
                        Site = c.String(unicode: false),
                        EmailContato = c.String(unicode: false),
                        Observacao = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Edicao = c.String(nullable: false, unicode: false),
                        NumeroPagina = c.Int(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SiteLivro = c.String(unicode: false),
                        EmailAutor = c.String(unicode: false),
                        CodigoEditora = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Editoras", t => t.CodigoEditora)
                .Index(t => t.CodigoEditora);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livros", "CodigoEditora", "dbo.Editoras");
            DropIndex("dbo.Livros", new[] { "CodigoEditora" });
            DropTable("dbo.Livros");
            DropTable("dbo.Editoras");
        }
    }
}
