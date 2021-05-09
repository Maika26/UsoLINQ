namespace UsoLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Memorias_Ram
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string marca { get; set; }

        [Required]
        [StringLength(50)]
        public string modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string compatibilidad { get; set; }

        [Required]
        [StringLength(50)]
        public string capacidad { get; set; }

        [Required]
        [StringLength(50)]
        public string formato { get; set; }
    }
}
