﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SourceCode.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập UserName")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Mời nhập Password")]
        public string Password { set; get; }
        public bool Remember { set; get; }
    }
}