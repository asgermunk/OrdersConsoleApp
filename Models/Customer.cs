﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrdersConsoleApp.Models
{
    public class Customer
    {
        public ObjectId Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
