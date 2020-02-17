using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public class Author
    {   
        public int AuthorId { get; set; }
        
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }        
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [StringLength(20,ErrorMessage ="Name of the city can not be longer than 20 chars")]
        
        public string City { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        [Range(10000,99999999,ErrorMessage ="Salary can not be less than 10000")]
        public int Salary { get; set; }
        
        public string Phone { get; set; }
        

        public Author()
        {

        }
        public Author(int authorId, string firstName, string lastName, string emailAddress,int salary,
                    string phoneNumber, string city)
        {
            AuthorId = authorId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            EmailAddress = emailAddress;
            Phone = phoneNumber;
            City = city;
        }

        public void clear()
        {
            AuthorId = 0;
            FirstName = "";
            LastName = "";
            Salary = 0;
            EmailAddress = "";
            Phone = "";
            City = "";
        }
    }
}
