﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string SlackHandle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CohortId { get; set; }
        public List<SelectListItem> CohortOptions { get; set; }
    }
}
