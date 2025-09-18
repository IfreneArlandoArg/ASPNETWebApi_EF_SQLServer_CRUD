﻿namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        public required string Email { get; set; }
        //public string? Department { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }

        

    }
}
