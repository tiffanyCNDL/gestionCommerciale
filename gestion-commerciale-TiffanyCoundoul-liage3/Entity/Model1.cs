namespace gestion_commerciale_TiffanyCoundoul_liage3.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(e => e.Reference)
                .IsFixedLength();

            modelBuilder.Entity<Article>()
                .Property(e => e.Libelle)
                .IsFixedLength();

            modelBuilder.Entity<Article>()
                .Property(e => e.Categorie)
                .IsFixedLength();

            modelBuilder.Entity<Commande>()
                .Property(e => e.Numero)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Nom)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Prenom)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Profil)
                .IsFixedLength();
        }
    }
}
