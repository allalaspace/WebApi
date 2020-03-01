using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class DCandidate
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public int fullName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int mobile { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int email { get; set; }
        [Column]
        public int age { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public int bloodGroup { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public int adresse { get; set; }





    }
}
