using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment5.Models
{
    [Table("Employee")]
    public class employee
    {
        [Key]
        public int Id { get; set; }

        public string EName { get; set; }

        public string EDesign { get; set; }

        public DateTime? EDOJ { get; set; }
    }
}
