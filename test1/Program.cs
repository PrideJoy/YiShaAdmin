using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using NPOI.OpenXmlFormats.Dml.Diagram;
using YiSha.Business.Cache;
using YiSha.Business.OrganizationManage;
using YiSha.Business.SystemManage;
using YiSha.Entity.OrganizationManage;
using YiSha.Entity.SystemManage;
using YiSha.Entity.ToolManage;
using YiSha.Model.Param.OrganizationManage;
using YiSha.Model.Param.SystemManage;
using YiSha.Service.SystemManage;
using YiSha.Util.Model;

namespace test1
{
    class Program
    {
       
        static void Main(string[] args)
        {


            ///张三
            /// /
            /// 131
            /// 123123
            /// 12312
            var asd = get();


            BirthdayBLL birbll = new BirthdayBLL();
            var a= birbll.GetEntity(1);
            PositionListParam aaListParam=new PositionListParam();
            Pagination pagination = new Pagination();
          



            Console.WriteLine(a.ToString());
           

        }


        public static  Task<TData<RoleEntity>> get()
        {
            RoleBLL bl = new RoleBLL();
            var asdasd =  bl.GetEntity(16508640061130146);
            return asdasd;
        }

        private static PositionBLL positionBLL = new PositionBLL();
        //public static async Task<IActionResult> GetPageListJson(PositionListParam param, Pagination pagination)
        //{
        //    TData<List<PositionEntity>> obj = await positionBLL.GetPageList(param, pagination);
        //    return obj;
        //}

    }
}
