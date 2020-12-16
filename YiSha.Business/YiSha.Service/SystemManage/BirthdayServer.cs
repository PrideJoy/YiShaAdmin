using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data.Repository;
using YiSha.Entity.SystemManage;
using YiSha.Entity.ToolManage;
using YiSha.Model.Param.SystemManage;


namespace YiSha.Service.SystemManage
{
    public class BirthdayServer : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<BirthdayeEntity>> GetList(AutoJobListParam param=null)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<BirthdayeEntity>> GetPageList(AutoJobListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<BirthdayeEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<BirthdayeEntity>(id);
        }

        public bool ExistJob(BirthdayeEntity entity)
        {
            var expression = LinqExtensions.True<BirthdayeEntity>();
            expression = expression.And(t => t.BaseIsDelete == 0);
            if (entity.Id.IsNullOrZero())
            {
                //expression = expression.And(t => t.JobGroupName == entity.JobGroupName && t.JobName == entity.JobName);
            }
            else
            {
                //expression = expression.And(t => t.JobGroupName == entity.JobGroupName && t.JobName == entity.JobName && t.Id != entity.Id);
            }
            return this.BaseRepository().IQueryable(expression).Count() > 0 ? true : false;
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(BirthdayeEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                await entity.Create();
                await this.BaseRepository().Insert<BirthdayeEntity>(entity);
            }
            else
            {
                await entity.Modify();
                await this.BaseRepository().Update<BirthdayeEntity>(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<BirthdayeEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<BirthdayeEntity, bool>> ListFilter(AutoJobListParam param)
        {
            var expression = LinqExtensions.True<BirthdayeEntity>();
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.JobName))
                {
                    expression = expression.And(t => t.BirthdayName.Contains(param.JobName));
                }
            }
            return expression;
        }
        #endregion
    }
}
