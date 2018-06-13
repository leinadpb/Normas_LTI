namespace NormasLTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NormasRegla
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NormaID { get; set; }

        [Required]
        [StringLength(1250)]
        public string NormaContent { get; set; }

        [Required]
        [StringLength(200)]
        public string CreatedBy { get; set; }
    }
}
