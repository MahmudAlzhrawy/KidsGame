using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace MoMo.Data { 
    public enum _Gender {Male,Female};
  [Table("Users")]
    public class User
    {
        [Key][Required]
        public String user_name { get; set; }
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public void SetPassword(string plainTextPassword)
        {
            Password = BCrypt.Net.BCrypt.HashPassword(plainTextPassword);
        }
        public bool VerifyPassword(string plainTextPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainTextPassword, Password);
        }
        public _Gender Gender { get; set; }
        public String Image { get; set; }
        public int Score { get; set; }  
        public ICollection<Result> Results { get; set; }
    }
}
