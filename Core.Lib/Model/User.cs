using System.ComponentModel.DataAnnotations;

namespace Core.Lib.Model
{
    public class User
    {
        [Key]
        public int PKID { get; set; }
        public string UserName { get; set; }
        public string UserAccount { get; set; }
        public string UserPassword { get; set; }
    }
}
