﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EZTech.Models
{
    public class CustomerPlan
    {
        public int CustomerPlanID { get; set; }

        [Required(ErrorMessage = "Plan name is required.")]
        [StringLength(50, ErrorMessage = "Plan name cannot exceed 50 characters.")]
        public string PlanName { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters.")]
        public string Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a non-negative number.")]
        public decimal Price { get; set; }
    }
}