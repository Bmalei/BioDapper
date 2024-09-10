using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Model
{
    [Table("Instructor")]
    public class InstructorModel
    {
        [Key]
        [Column("InstructorId")]
        public int Id { get; set; }

        [Column("InstructorName")]
        public string InstructorName { get; set; }

        [Column("Description")]
        public string Description { get; set; }

    }
}
