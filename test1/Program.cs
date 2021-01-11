using System;
using System.Collections.Generic;
using System.Threading;
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
using YiSha.Model.Result.SystemManage;
using YiSha.Service.OrganizationManage;
using YiSha.Service.SystemManage;
using YiSha.Util.Model;

namespace test1
{
    class Program
    {
        public static PositionBLL positionBLL = new PositionBLL();
        static  void Main(string[] args)
        {

            //var e = GetPageListJson();
            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(e.Result));

            var e = GetBirthday();
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(e.Result));
            
            //Task.Run(() =>
            //{
            //    var e = GetPageListJson();
            //    Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(e.Result));
            //});
            Thread.Sleep(50000);
            //var b = GetList(null);
            //var a = GetPageListJson();
            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(a));
            Console.WriteLine("ok");
        }





        public static async Task<TData<List<NewsEntity>>> GetList2(NewsListParam param)
        {
            AreaBLL areaBLL = new AreaBLL();
            NewsService newsService = new NewsService();
            TData<List<NewsEntity>> obj = new TData<List<NewsEntity>>();
            areaBLL.SetAreaParam(param);
            obj.Data = await newsService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        [HttpGet]
        public static async Task<TData<PositionEntity>> GetPageListJson()
        {

            TData<PositionEntity> obj = await positionBLL.GetEntity(16508640061130139);

            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(obj));

            return obj;
        }



        public static BirthdayBLL BirthdayBLL = new BirthdayBLL();

        [HttpGet]
        public static async Task<TData<List<BirthdayeEntity>>> GetBirthday()
        {

            TData<List<BirthdayeEntity>> obj = await BirthdayBLL.GetList(null);

            //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(obj));

            return obj;
        }


        //public static string ToJson(this object obj)
        //{
        //    try
        //    {
        //        if (obj == null) return "";
        //        return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        //    }
        //    catch (Exception ex)
        //    {
        //        return "";
        //    }
        //}


    }


}
