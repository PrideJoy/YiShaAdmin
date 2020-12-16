using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.SystemManage;
using YiSha.Entity.ToolManage;
using YiSha.Model.Param.SystemManage;
using YiSha.Service.SystemManage;

namespace YiSha.Business.SystemManage
{
    public class BirthdayBLL
    {
        private BirthdayServer birthdayServer = new BirthdayServer();

        public async Task<TData<List<BirthdayeEntity>>> GetList(AutoJobLogListParam param=null)
        {
            TData<List<BirthdayeEntity>> obj = new TData<List<BirthdayeEntity>>();
            obj.Data = await birthdayServer.GetList();
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }


        public  Task<BirthdayeEntity> GetEntity(long id = 1)
        {
            TData<BirthdayeEntity> obj = new TData<BirthdayeEntity>();
            var asd=  birthdayServer.GetEntity(id);
            //obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return asd;
        }

    }
}
