////////////////////////////////////////////////
// 生成时间: 2016-10-18 09:22:52
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Model;
using Common;
using Dal;

namespace Bll
{
 public class PolylineBll
 {
PolylineDal dal=new PolylineDal();
        /// <summary>
       /// 添加
       /// </summary>
       public bool AddPolyline(PolylineModel model)
       {
         return  dal.AddPolyline(model);
       }
         /// <summary>
       /// 修改
       /// </summary>
        public bool UpdataPolyline(PolylineModel model)
       {
          return  dal.UpdataPolyline(model);
       }
         /// <summary>
       /// 分页列表
       /// </summary>
        
        public List<PolylineModel> PolylineList(Criteria c, int CurPage, int pageSize, out int OutCount)
       {
            return dal.PolylineList(c,CurPage,pageSize,out OutCount);
         }
             
            /// <summary>
        /// 列表,不分页
        /// </summary>
          public List<PolylineModel> PolylineList(Criteria c)
        {
            return dal.PolylineList(c);
        }
        
               /// <summary>
        /// 取出总数
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int GetCount(Criteria c)
       {
           return dal.GetCount(c);
       }
         
            /// <summary>
       /// 根据主键值取出数据
       /// </summary>
       public PolylineModel PolylineDetail(int? Id)
       {
             return dal.PolylineDetail(Id);
       }
           /// <summary>
       /// 删除
       /// </summary>
          public bool DeletePolyline(int? Id)
       {
           return  dal.DeletePolyline(Id);
       }
       }
         
}