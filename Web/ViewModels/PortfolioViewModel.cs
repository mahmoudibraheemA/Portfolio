﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid ID { get; set; }
        public string Projectname { get; set; }
        public string Decsription { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile file { get; set; }
    }
}
