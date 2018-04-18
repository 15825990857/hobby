using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Core.Model
{
    [Description]
   public class User
    {
        public int Id { get; set; }
         [Required]
         [MaxLength(250)]
        public string Name { get; set; }
        public string Pwd { get; set; }
        public DateTime Addtime { get; set; }
        public int Status { get; set; }
      
        
    }
}
