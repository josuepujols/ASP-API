using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Person
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string apellido { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int edad { get; set; }

        [Required]
        [Column(TypeName = "varchar(11)")]
        public string numero_identidad { get; set; }
    }
}
