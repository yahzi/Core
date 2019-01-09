using Core.Common.Common_Enum;
using Core.Lib.Model;
using System;
using System.Linq;

namespace Core.Lib
{
    public class DbInit
    {

        public static void InitDB(DBcontext dBcontext)
        {
            //dBcontext.Database.EnsureCreated();
            #region Initialize the User data
            if (dBcontext.User.Any())
            {
                var users = new User[]
                   {
                        new User
                        {
                            UserName ="徐志",
                            LoginAccount ="xz",
                            LoginPassword ="123456",
                            OnFreezed =Convert.ToInt32(CommonEnum.BaseModel.不冻结),
                            IsInternal =Convert.ToInt32(CommonEnum.BaseModel.内部账号),
                            Valid =Convert.ToInt32(CommonEnum.BaseModel.有效),
                            CreateTime =DateTime.Now,
                            LastModifyTime =DateTime.Now
                        },
                        new User
                        {
                            UserName ="刘秋林",
                            LoginAccount ="lql",
                            LoginPassword ="123456",
                            OnFreezed =Convert.ToInt32(CommonEnum.BaseModel.不冻结),
                            IsInternal =Convert.ToInt32(CommonEnum.BaseModel.内部账号),
                            Valid =Convert.ToInt32(CommonEnum.BaseModel.有效),
                            CreateTime =DateTime.Now,
                            LastModifyTime =DateTime.Now
                        },
                        new User
                        {
                            UserName ="阮国友",
                            LoginAccount ="rgy",
                            LoginPassword ="123456",
                            OnFreezed =Convert.ToInt32(CommonEnum.BaseModel.不冻结),
                            IsInternal =Convert.ToInt32(CommonEnum.BaseModel.内部账号),
                            Valid =Convert.ToInt32(CommonEnum.BaseModel.有效),
                            CreateTime =DateTime.Now,
                            LastModifyTime =DateTime.Now
                        },
                        new User
                        {
                            UserName ="聂思奥",
                            LoginAccount ="nsa",
                            LoginPassword ="123456",
                            OnFreezed =Convert.ToInt32(CommonEnum.BaseModel.不冻结),
                            IsInternal =Convert.ToInt32(CommonEnum.BaseModel.内部账号),
                            Valid =Convert.ToInt32(CommonEnum.BaseModel.有效),
                            CreateTime =DateTime.Now,
                            LastModifyTime =DateTime.Now
                        },
                        new User
                        {
                            UserName ="宋哲",
                            LoginAccount ="sz",
                            LoginPassword ="123456",
                            OnFreezed =Convert.ToInt32(CommonEnum.BaseModel.不冻结),
                            IsInternal =Convert.ToInt32(CommonEnum.BaseModel.内部账号),
                            Valid =Convert.ToInt32(CommonEnum.BaseModel.有效),
                            CreateTime =DateTime.Now,
                            LastModifyTime =DateTime.Now
                        }
                   };

                foreach (User user in users)
                {
                    dBcontext.User.Add(user);
                }
                dBcontext.SaveChanges();
            }
            #endregion

            #region Initialize the Sys_user data
            if (!dBcontext.Sys_User.Any())
            {
                var sys_users = new Sys_User[]
                {
                    new Sys_User
                    {
                        Sys_UserName ="管理员",
                        Sys_LoginAccount ="admin",
                        Sys_LoginPassword ="123456",
                        OnFreezed =Convert.ToInt32(CommonEnum.BaseModel.不冻结),
                        IsInternal =Convert.ToInt32(CommonEnum.BaseModel.内部账号),
                        Valid =Convert.ToInt32(CommonEnum.BaseModel.有效),
                        CreateTime =DateTime.Now,
                        LastModifyTime =DateTime.Now
                    }
                };

                foreach (Sys_User sys_User in sys_users)
                {
                    dBcontext.Sys_User.Add(sys_User);
                }

                dBcontext.SaveChanges();
            }
            #endregion

        }
    }
}
