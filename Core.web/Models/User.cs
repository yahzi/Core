using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.web.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "名字")]
        public string Name { get; set; }
        [Display(Name = "邮箱")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "登陆账号")]
        public string Account { get; set; }
    }
}
