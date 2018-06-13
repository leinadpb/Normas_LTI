namespace NormasLTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int StudentID { get; set; }

        [Required]
        [StringLength(120)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(60)]
        public string LoginName { get; set; }

        [Column(TypeName = "date")]
        public DateTime RegisteredDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Domain { get; set; }

        [Required]
        [StringLength(20)]
        public string ComputerName { get; set; }

        [StringLength(120)]
        public string SubjectName { get; set; }

        [StringLength(10)]
        public string SubjectSection { get; set; }

        [StringLength(10)]
        public string SubjectCode { get; set; }

        public int? TeacherID { get; set; }
    }
}
