﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
 public   class UserCustomerDto:IDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
       
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }
}
