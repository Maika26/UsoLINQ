namespace UsoLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Placas_Bases
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string tipo { get; set; }

        [Required]
        [StringLength(50)]
        public string factor_de_forma { get; set; }

        [Required]
        [StringLength(50)]
        public string slot_ram { get; set; }

        [Required]
        [StringLength(50)]
        public string socket { get; set; }

        public int puerto_pci { get; set; }

        public int puerto_sata { get; set; }

        public int puerto_usb { get; set; }
    }
}
