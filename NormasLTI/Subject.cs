namespace NormasLTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subject
    {
        public int SubjectID { get; set; }

        [Required]
        [StringLength(120)]
        public string SubjectName { get; set; }

        [Required]
        [StringLength(10)]
        public string SubjectCode { get; set; }
    }
}
