﻿using System;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmplloyeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
