﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarageAppWeb.Models
{
    public class Client1
    {   
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Cars CarId { get; set; }

    }

}