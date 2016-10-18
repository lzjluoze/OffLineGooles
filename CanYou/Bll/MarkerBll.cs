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
 public class MarkerBll
 {
MarkerDal dal=new MarkerDal();
        /// <summary>
       /// 添加
       /// </summary>
       public bool AddMarker(MarkerModel model)
       {
         return  dal.AddMarker(model);
       }
         /// <summary>
       /// 修改
       /// </summary>
        public bool UpdataMarker(MarkerModel model)
       {
          return  dal.UpdataMarker(model);
       }
         /// <summary>
       /// 分页列表
       /// </summary>
        
        public List<MarkerModel> MarkerList(Criteria c, int CurPage, int pageSize, out int OutCount)
       {
            return dal.MarkerList(c,CurPage,pageSize,out OutCount);
         }
             
            /// <summary>
        /// 列表,不分页
        /// </summary>
          public List<MarkerModel> MarkerList(Criteria c)
        {
            return dal.MarkerList(c);
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
       public MarkerModel MarkerDetail(int? Id)
       {
             return dal.MarkerDetail(Id);
       }
           /// <summary>
       /// 删除
       /// </summary>
          public bool DeleteMarker(int? Id)
       {
           return  dal.DeleteMarker(Id);
       }
       }
         
}