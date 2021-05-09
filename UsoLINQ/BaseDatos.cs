using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UsoLINQ
{
    public partial class BaseDatos : DbContext
    {
        public BaseDatos()
            : base("name=BaseDatos")
        {
        }

        public virtual DbSet<Discos_Duros> Discos_Duros { get; set; }
        public virtual DbSet<Disipadore> Disipadores { get; set; }
        public virtual DbSet<Fuentes_Poder> Fuentes_Poder { get; set; }
        public virtual DbSet<Gabinete> Gabinetes { get; set; }
        public virtual DbSet<Memorias_Ram> Memorias_Ram { get; set; }
        public virtual DbSet<Monitore> Monitores { get; set; }
        public virtual DbSet<Mouse> Mice { get; set; }
        public virtual DbSet<Placas_Bases> Placas_Bases { get; set; }
        public virtual DbSet<procesadore> procesadores { get; set; }
        public virtual DbSet<Tarjetas_Videos> Tarjetas_Videos { get; set; }
        public virtual DbSet<Teclado> Teclados { get; set; }
        public virtual DbSet<Ventiladore> Ventiladores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Discos_Duros>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Discos_Duros>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Discos_Duros>()
                .Property(e => e.capacidad)
                .IsUnicode(false);

            modelBuilder.Entity<Discos_Duros>()
                .Property(e => e.compatibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<Disipadore>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Disipadore>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Disipadore>()
                .Property(e => e.tipo_disipador)
                .IsUnicode(false);

            modelBuilder.Entity<Disipadore>()
                .Property(e => e.tamaño_ventilador)
                .IsUnicode(false);

            modelBuilder.Entity<Fuentes_Poder>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Fuentes_Poder>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Fuentes_Poder>()
                .Property(e => e.potencia)
                .IsUnicode(false);

            modelBuilder.Entity<Fuentes_Poder>()
                .Property(e => e.fuente_alimentacion)
                .IsUnicode(false);

            modelBuilder.Entity<Gabinete>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Gabinete>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Gabinete>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<Gabinete>()
                .Property(e => e.placas_madre_compatibles)
                .IsUnicode(false);

            modelBuilder.Entity<Memorias_Ram>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Memorias_Ram>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Memorias_Ram>()
                .Property(e => e.compatibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<Memorias_Ram>()
                .Property(e => e.capacidad)
                .IsUnicode(false);

            modelBuilder.Entity<Memorias_Ram>()
                .Property(e => e.formato)
                .IsUnicode(false);

            modelBuilder.Entity<Monitore>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Monitore>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Monitore>()
                .Property(e => e.tamaño_pantalla)
                .IsUnicode(false);

            modelBuilder.Entity<Monitore>()
                .Property(e => e.tipo_pantalla)
                .IsUnicode(false);

            modelBuilder.Entity<Mouse>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Mouse>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Mouse>()
                .Property(e => e.inalambrico)
                .IsUnicode(false);

            modelBuilder.Entity<Mouse>()
                .Property(e => e.alcance_maximo)
                .IsUnicode(false);

            modelBuilder.Entity<Placas_Bases>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Placas_Bases>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Placas_Bases>()
                .Property(e => e.factor_de_forma)
                .IsUnicode(false);

            modelBuilder.Entity<Placas_Bases>()
                .Property(e => e.slot_ram)
                .IsUnicode(false);

            modelBuilder.Entity<Placas_Bases>()
                .Property(e => e.socket)
                .IsUnicode(false);

            modelBuilder.Entity<procesadore>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<procesadore>()
                .Property(e => e.plataforma)
                .IsUnicode(false);

            modelBuilder.Entity<procesadore>()
                .Property(e => e.socket)
                .IsUnicode(false);

            modelBuilder.Entity<procesadore>()
                .Property(e => e.linea)
                .IsUnicode(false);

            modelBuilder.Entity<procesadore>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<procesadore>()
                .Property(e => e.velocidad)
                .IsUnicode(false);

            modelBuilder.Entity<Tarjetas_Videos>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Tarjetas_Videos>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Tarjetas_Videos>()
                .Property(e => e.velocidad_memoria)
                .IsUnicode(false);

            modelBuilder.Entity<Tarjetas_Videos>()
                .Property(e => e.tamaño_memoria)
                .IsUnicode(false);

            modelBuilder.Entity<Teclado>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Teclado>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Teclado>()
                .Property(e => e.pad_numerico)
                .IsUnicode(false);

            modelBuilder.Entity<Teclado>()
                .Property(e => e.forma_teclas)
                .IsUnicode(false);

            modelBuilder.Entity<Ventiladore>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Ventiladore>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Ventiladore>()
                .Property(e => e.velocidad)
                .IsUnicode(false);

            modelBuilder.Entity<Ventiladore>()
                .Property(e => e.voltaje)
                .IsUnicode(false);
        }
    }
}
