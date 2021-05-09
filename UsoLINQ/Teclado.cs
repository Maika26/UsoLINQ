namespace UsoLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teclados")]
    public partial class Teclado
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
        public string pad_numerico { get; set; }

        [Required]
        [StringLength(50)]
        public string forma_teclas { get; set; }
    }
}
