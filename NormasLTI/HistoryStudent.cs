namespace NormasLTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistoryStudent")]
    public partial class HistoryStudent
    {
        public int HistoryStudentID { get; set; }

        [Required]
        [StringLength(60)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(120)]
        public string DisplayName { get; set; }

        [Column(TypeName = "date")]
        public DateTime RegisteredDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Domain { get; set; }

        [Required]
        [StringLength(20)]
        public string ComputerName { get; set; }

        [StringLength(80)]
        public string SubjectName { get; set; }

        [StringLength(10)]
        public string SubjectSection { get; set; }

        public int? TeacherID { get; set; }
    }
}
