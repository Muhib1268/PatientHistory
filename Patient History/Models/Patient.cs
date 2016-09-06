using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Patient_History.Models
{
    public class Patient
    {
        public int PatientID { get; set; }


        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; }



        [Display(Name = "Recording Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RecordingDate { get; set; }



        [StringLength(20, MinimumLength = 3)]
        public string Gender { get; set; }


        [Display(Name = "Contact Number")]
        [DataType(DataType.Currency)]
        public decimal PrimaryContacts { get; set; }


        [Display(Name = "Patient Complaints")]
        [StringLength(80, MinimumLength = 3)]
        public string Complaints { get; set; }

    }

    public class PatientData : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}