using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Lib.Model
{
    public class BaseModel
    {
        [Key]
        public int PKID { get; set; }

        public int Valid { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastModifyTime { get; set; }
    }
}
