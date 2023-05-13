using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Models;
using ProjectCachoeiro.Web.Models.Utilitarios;
using System;
using System.Linq;
using ProjectCachoeiro.Web.Comercial;
using System.Threading;
using System.Threading.Tasks;
using ProjectCachoeiro.Web.Models.Empresa;
using ProjectCachoeiro.Web.Models.Produtos;
using ProjectCachoeiro.Web.Models.Comercial;

namespace ProjectCachoeiro.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            AddTimestamps();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is LogEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            //TODO: não está conseguindo capturar o nome do usuário. Erro ao cadastrar algo.
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((LogEntity)entity.Entity).DateCreated = DateTime.UtcNow.ToString();
                    //((LogEntity)entity.Entity).UserCreated = user.;
                }
                ((LogEntity)entity.Entity).DateModified = DateTime.UtcNow.ToString();
               // ((LogEntity)entity.Entity).UserModified = _user;
            }
        }
        
        public DbSet<Bundles> Bundle { get; set; }
        public DbSet<BundleItem> BundleItem { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<GrupoDeClientes> GrupoDeClientes { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Proposta> Proposta { get; set; }
        public DbSet<Familia> Familia { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Invite> Invite { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Qualidade> Qualidade { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Espessura> Espessura { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<OpcoesPagamento> OpcoesPagamento { get; set; }
        public DbSet<Cor> Cor { get; set; }
        public DbSet<ContaCorrente> ContaCorrente { get; set; }
    }
}
