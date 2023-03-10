//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Courses_Offered
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Courses_Offered()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }

        public int offered_id { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public int course_id { get; set; }
        [Display(Name = "Start Time")]
        public System.TimeSpan start_time { get; set; }
        [Display(Name = "End Time")]
        public System.TimeSpan end_time { get; set; }
        [Required]
        [Display(Name = "Doctor")]
        public int doctor_id { get; set; }
        public Nullable<int> semester_id { get; set; }
        [Required]
        [Display(Name = "Seat Count")]
        public Nullable<int> Seat_Count { get; set; }
        [Required]
        public string Hall { get; set; }
        [Required]
        [Display(Name = "Capacity")]
        public Nullable<int> Capacity { get; set; }
        [Required]
        public Nullable<int> Registered { get; set; }
        [Required]
        [Display(Name = "Days")]
        public Nullable<int> Days_id { get; set; }

        public virtual Cours Cours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual Day Day { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual semester semester { get; set; }
    }
}
