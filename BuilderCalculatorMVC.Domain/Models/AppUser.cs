﻿using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Models
{
    public class AppUser :BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }

    }
}
