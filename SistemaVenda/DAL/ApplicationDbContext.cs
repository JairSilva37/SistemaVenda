using Microsoft.EntityFrameworkCore;
using SistemaVenda.Entidades;

namespace SistemaVenda.DAL
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaProdutos> VendaProdutos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<VendaProdutos>().HasKey(x => new { x.CodigoVenda, x.CodigoProduto });

            builder.Entity<VendaProdutos>()
                .HasOne(x => x.Venda) //tem um
                .WithMany(y => y.Produtos) //tem muitos
                .HasForeignKey(x => x.CodigoVenda); // tem chave estrangeira

            builder.Entity<VendaProdutos>()
                .HasOne(x => x.Produto) //tem um
                .WithMany(y => y.Vendas) //tem muitos
                .HasForeignKey(x => x.CodigoProduto);

        }
    }
}
