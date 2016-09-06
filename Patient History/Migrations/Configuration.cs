namespace Patient_History.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Patient_History.Models.PatientData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Patient_History.Models.PatientData context)
        {
            context.Patients.AddOrUpdate(i => i.FirstName,
     new Patient
     {
         FirstName = "Harry",
         LastName = "Sally",
         RecordingDate = DateTime.Parse("1989-1-11"),
         Gender = "Male",
         PrimaryContacts = 012689754564
     },

      new Patient
      {
          FirstName = "Harry",
          LastName = "Potter",
          RecordingDate = DateTime.Parse("1990-3-11"),
          Gender = "Male",
          PrimaryContacts = 01268975565
      },

      new Patient
      {
          FirstName = "Shamsul",
          LastName = "Arefin",
          RecordingDate = DateTime.Parse("1859-5-09"),
          Gender = "Male",
          PrimaryContacts = 012689755664
      },

      new Patient
       {
        FirstName = "Christina",
        LastName = "Applebee",
        RecordingDate = DateTime.Parse("1949-7-11"),
        Gender = "Female",
        PrimaryContacts = 012689754587
            }
         );
        }
    }
}
