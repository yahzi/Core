
namespace Core.Lib.Model
{
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public string LoginAccount { get; set; }
        public string LoginPassword { get; set; }
        public int OnFreezed { get; set; }
        public int IsInternal { get; set; }
    }
}
