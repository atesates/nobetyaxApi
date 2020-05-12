using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Northwind.Entities.Concrete;
using WM.Northwind.Entities.Concrete.Authorization;

namespace WM.Northwind.DataAccess.Concrete.EntityFramework.Mapping.Authorization
{
    public class NobetUstGrupMobilUygulamaMap : EntityTypeConfiguration<NobetUstGrupMobilUygulama>
    {
        public NobetUstGrupMobilUygulamaMap()
        {
            // Key
            this.HasKey(t => t.Id);

            #region Table & Column Mappings
            this.ToTable(@"UserRoles", @"Yetki");
            //this.ToTable("UserRoles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.NobetUstGrupId).HasColumnName("NobetUstGrupId");
            this.Property(t => t.MazeretEkleme).HasColumnName("MazeretEkleme");
            this.Property(t => t.MazeretSilme).HasColumnName("MazeretSilme");
            this.Property(t => t.NobetDegisimTalepGorme).HasColumnName("NobetDegisimTalepGorme");
            this.Property(t => t.NobetDegisimTalepEkleme).HasColumnName("NobetDegisimTalepEkleme");
            this.Property(t => t.NobetDegisimTalepSilme).HasColumnName("NobetDegisimTalepSilme");
            this.Property(t => t.OrtalamaIstatistikGorme).HasColumnName("OrtalamaIstatistikGorme");

            #endregion

            #region Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MazeretEkleme).IsRequired();
            this.Property(t => t.MazeretSilme).IsRequired();
            this.Property(t => t.NobetDegisimTalepGorme).IsRequired();
            this.Property(t => t.NobetDegisimTalepEkleme).IsRequired();
            this.Property(t => t.NobetDegisimTalepSilme).IsRequired();
            this.Property(t => t.OrtalamaIstatistikGorme).IsRequired();

            this.Property(t => t.NobetUstGrupId)
               .IsRequired()
               .HasColumnAnnotation("Index",
                       new IndexAnnotation(
                           new IndexAttribute("UN_NobetUstGruplar")
                           {
                               IsUnique = true,
                               Order = 1
                           }));

           
            #endregion

            #region Relationships
            this.HasRequired(t => t.NobetUstGrup)
                    .WithMany(et => et.NobetUstGrupMobilUygulamalar)
                    .HasForeignKey(t => t.NobetUstGrupId);

            #endregion
        }
    }
}
