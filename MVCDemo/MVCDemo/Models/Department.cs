﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class tblDepartment
    {

    }

    public class DepartmentMetaData
    {
        [Display(Name ="Department Name")]
        public string Name { get; set; }

    }


}