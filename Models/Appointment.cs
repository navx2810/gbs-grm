using System;
using System.Collections.Generic;

namespace GRM.Models {
    public class Appointment {
        public int Id { get; set; }
        public Pet Pet { get; set; }
        public DateTime Date { get; set; }
        public List<Service> Services { get; set; }
        public double Cost { get; set; }
        public string CustomerNotes { get; set; }
        public string GroomerNotes { get; set; }
    }
}