namespace Core.Lib.Model
{
    public class Sys_User : BaseModel
    {
        public string Sys_UserName { get; set; }
        public string Sys_LoginAccount { get; set; }
        public string Sys_LoginPassword { get; set; }
        public int OnFreezed { get; set; }
        public int IsInternal { get; set; }
    }
}
