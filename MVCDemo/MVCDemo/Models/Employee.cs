using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class tblEmployee
    {

    }

    public class EmployeeMetaData
    {
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }

        [Display(Name = "Date Of Birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Display(Name = "Department Id")]

        public Nullable<int> DepartmentId { get; set; }

        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string City { get; set; }
    }
}