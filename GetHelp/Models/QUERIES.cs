namespace GetHelp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QUERIES
    {
        [Key]
        public int QId { get; set; }

        [Required]
        [StringLength(128)]
        public string QName { get; set; }

        public int QTel { get; set; }

        [Required]
        [StringLength(256)]
        public string QAddr { get; set; }

        [Required]
        [StringLength(256)]
        public string QTask { get; set; }
    }
}
