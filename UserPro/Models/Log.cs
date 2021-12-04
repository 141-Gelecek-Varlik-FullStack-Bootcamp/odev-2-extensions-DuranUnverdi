using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserPro.Models
{
    [Table("Logs")]
    public class Log
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,Display(Name = "Date")]
        public DateTime Date { get; set; }
        [StringLength(100), Display(Name = "Controller Name")]
        public string ControllerName { get; set; }
    }
}
