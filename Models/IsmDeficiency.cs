using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class IsmDeficiency
    {
        public int IsmDeficiencyId { get; set; }
        public int InspectionId { get; set; }
        public string GroupCode { get; set; }
        public string DeficiencyCode { get; set; }
        public string Actions { get; set; }
        public string DescriptionOfDeficiency { get; set; }
        public bool Ro { get; set; }
        public bool AccidentalDamage { get; set; }
        public string Rca { get; set; }
        public string RcaText { get; set; }
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

    }
}
