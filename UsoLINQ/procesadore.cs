namespace UsoLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class procesadore
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string marca { get; set; }

        [Required]
        [StringLength(50)]
        public string plataforma { get; set; }

        [Required]
        [StringLength(50)]
        public string socket { get; set; }

        [Required]
        [StringLength(50)]
        public string linea { get; set; }

        [Required]
        [StringLength(50)]
        public string modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string velocidad { get; set; }

        public int cantidad_nucleos { get; set; }

        public int? stock { get; set; }

        public int? precio { get; set; }
    }
}
