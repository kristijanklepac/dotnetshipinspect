using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class Accident
    {
        public int AccidentId { get; set; }
        public string ShipNameId { get; set; }
        public string Master { get; set; }
        public string ChiefEngineer { get; set; }
        public string Place { get; set; }
        public DateTime AccidentDate { get; set; }
        public string TypeOfEvent { get; set; }
        public string TypeOfOccurence { get; set; }
        public string DescriptionOfEvent { get; set; }
        public string Rca { get; set; }
        public string ControlAction { get; set; }
        public string ControlUpload { get; set; }
        public DateTime ControlDueDate { get; set; }
        public DateTime ControlDoneDate { get; set; }
        public bool ControlRectified { get; set; }
        public string CorrectiveAction { get; set; }
        public string CorrectiveUpload { get; set; }
        public DateTime CorrectiveDueDate { get; set; }
        public DateTime CorrectiveDoneDate { get; set; }
        public bool CorrectiveRectified { get; set; }
        public string PreventiveAction { get; set; }
        public string PreventiveUpload { get; set; }
        public DateTime PreventiveDueDate { get; set; }
        public DateTime PreventiveDoneDate { get; set; }
        public bool PreventiveRectified { get; set; }
        public string LeassonLearned { get; set; }
    }
}
