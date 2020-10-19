using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class tblMSSubDept
    {
        [Key]
        public int CompanyID { get; set; }
        //[Required]
        public string Division { get; set; }
        [Required]
        public string Dept { get; set; }
        [Required]
        public string SubDept { get; set; }
        [Required]
        public string Ket { get; set; }
        [Required]
        public string CostCenter { get; set; }
        public bool IsActive { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public string CreateBy { get; set; }
       
        public DateTimeOffset? CreateDt { get; set; }
       
    }
}
