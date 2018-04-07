namespace Binary2Object.domain {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext {
        public Context()
            : base("name=Connection") {
        }

        public virtual DbSet<UsuarioPreferenciaDomain> UsuarioPreferencia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<UsuarioPreferenciaDomain>()
                .Property(e => e.ID_Programa)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioPreferenciaDomain>()
                .Property(e => e.DS_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioPreferenciaDomain>()
                .Property(e => e.NM_Objeto)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioPreferenciaDomain>()
                .Ignore(e => e.DataGridPreference);
        }
    }
}
