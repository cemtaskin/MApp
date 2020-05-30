using System;
using System.Collections.Generic;
using MessaginApp.API.Models;

namespace MessaginApp.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
      
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public DateTime Created{ get; set; }  
        public DateTime LastActive { get; set; } 
        public string Introduction { get; set; }
        public string Interests { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotoForDetailDto> Photos { get; set; }  
    }
}