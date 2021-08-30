using System;
namespace demomvc.Models
{
    public class contacto
    {
        public string Id {get; set;}
        public string Email {get; set;}
        public string Name {get; set;}
        public string Phone {get; set;}
        public string Comment{get; set;}
        public DateTime Birthday{get; set;}
        public string Gender{get; set;}
    }
}