using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NiceTrip.Models
{
    public class Pessoa
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public String Senha { get; set; }
    }
}