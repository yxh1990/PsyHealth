using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XjHealth.Model;
using Newtonsoft.Json.Linq;

namespace XjHealth.BLL
{
    public class UserBLL
    {
        /// <summary>
        /// 处理用户是否登录成功
        /// </summary>
        /// <param name="jsonstr"></param>
        /// <returns></returns>
       public ResultInfo check_user_login(string jsonstr)
        {
            var obj = JObject.Parse(jsonstr);
            var resultCode = obj["resultCode"].ToString();
            var resultMsg = obj["resultMsg"].ToString();
            var pi =  obj["pi"].ToString().Length;

            ResultInfo result = new ResultInfo();
            if (resultCode == "0" && pi !=0)
            {
                result.Resultcode = resultCode;
                result.Resultmsg = "";
                setAppLoginUser(jsonstr);
            }
            else if(resultCode == "0" && pi == 0)
            {
                result.Resultcode = resultCode;
                result.Resultmsg = "用户名或者密码输入错误!";
            }
            else
            {
                result.Resultcode = resultCode;
                result.Resultmsg = resultMsg;
            }

            return result;
        }

        
        /// <summary>
        /// 保存登录用户信息
        /// </summary>
       public void setAppLoginUser(string jsonstr)
        {
            var obj = JObject.Parse(jsonstr);
            Userinfo userobj = new Userinfo();
            userobj.Name = obj["pi"]["name"].ToString();
            userobj.Id=Int32.Parse(obj["pi"]["id"].ToString());
            userobj.PicPath = obj["pi"]["picPath"].ToString();
            userobj.Code = obj["pi"]["code"].ToString();
            userobj.LogonName = obj["pi"]["logonName"].ToString();
            userobj.Age =Int32.Parse(obj["pi"]["age"].ToString());
            userobj.Birthday = DateTime.Parse(obj["pi"]["birthday"].ToString());
            userobj.DeptClassId = Int32.Parse(obj["pi"]["deptClassId"].ToString());
            userobj.Edu = obj["pi"]["edu"].ToString();
            userobj.Nation = obj["pi"]["nation"].ToString();
            userobj.Native2 = obj["pi"]["native2"].ToString();
            userobj.RoleId = Int32.Parse(obj["pi"]["roleId"].ToString());
            userobj.RoleName = obj["pi"]["roleName"].ToString();
            userobj.Sex = obj["pi"]["sex"].ToString();
            userobj.DeptInfo = obj["pi"]["deptInfo"].ToString();
            userobj.AuxProps = obj["pi"]["auxProps"].ToString();
            App.CurrentUser = userobj;
        }


        /// <summary>
        /// 处理用户更新密码是否成功
        /// </summary>
        /// <returns></returns>
        public ResultInfo check_user_updatepass(string jsonstr)
        {
            var obj = JObject.Parse(jsonstr);
            ResultInfo result = new ResultInfo();

            result.Resultcode = obj["resultCode"].ToString();
            result.Resultmsg = "修改密码失败异常";
            if (result.Resultcode!="0")
            { 
              result.Id = obj["id"].ToString();
              result.Resultmsg = obj["resultMsg"].ToString();
            }

            return result;
        }
    }
}
