﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class LoginViewModel
    {
        [DisplayName("Name")]
        [StringLength(50)]
        public string Name { get; set; }
        [DisplayName("Password")]
        [StringLength(15)]
        public string Password { get; set; }
    }
}