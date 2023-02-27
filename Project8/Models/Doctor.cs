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

    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            this.Courses_Offered = new HashSet<Courses_Offered>();
        }

        public int Doctor_Id { get; set; }
        [Required]
        [Display(Name = "Doctor Name")]
        public string Doctor_Name { get; set; }
        [Required]
        [Display(Name = "Doctor Image")]
        public string Doctor_Image { get; set; }
        [Required]
        [Display(Name = "Doctor Phone")]
        [RegularExpression("((079)|(078)|(077)){1}[0-9]{7}", ErrorMessage = "Isn't a Jordanian Number.")]
        public string Doctor_Phone { get; set; }
        [Required]
        [Display(Name = "Doctor Email")]
        [EmailAddress]
        public string Doctor_Email { get; set; }
        public string User_ID { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses_Offered> Courses_Offered { get; set; }
    }
}
