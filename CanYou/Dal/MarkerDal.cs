////////////////////////////////////////////////
// 生成时间: 2016-10-18 09:22:52
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using Common;
using System.Data;
using Model;
namespace Dal
{
    public class MarkerDal
    {
  
         /// <summary>
       /// 添加
       /// </summary>
       public bool AddMarker(MarkerModel model)
       {

          
        
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Marker(");
            strSql.Append("Lat,Lng,Title,Rank,Intro,PolylineId,AddTime)");
            strSql.Append(" values (");
            strSql.Append("@Lat,@Lng,@Title,@Rank,@Intro,@PolylineId,@AddTime)");
             SQLiteParameter[] parameters = {
                new  SQLiteParameter("@Lat", DBNull.Value),
                new  SQLiteParameter("@Lng", DBNull.Value),
                new  SQLiteParameter("@Title", DBNull.Value),
                new  SQLiteParameter("@Rank", DBNull.Value),
                new  SQLiteParameter("@Intro", DBNull.Value),
                new  SQLiteParameter("@PolylineId", DBNull.Value),
                  new  SQLiteParameter("@AddTime", DBNull.Value)
              };
                    parameters[0].Value = model.Lat;
                    parameters[1].Value = model.Lng;
                    parameters[2].Value = model.Title;
                    parameters[3].Value = model.Rank;
                    parameters[4].Value = model.Intro;
                    parameters[5].Value = model.PolylineId;
                    parameters[6].Value = model.AddTime;

              
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
       }
       /// <summary>
       /// 修改
       /// </summary>
       public bool UpdataMarker(MarkerModel model)
       {
 StringBuilder strSql = new StringBuilder();
           strSql.Append("update Marker set ");
                      strSql.Append("Lat=@Lat,");
                      strSql.Append("Lng=@Lng,");
                      strSql.Append("Title=@Title,");
                      strSql.Append("Rank=@Rank,");
                      strSql.Append("Intro=@Intro,");
                       strSql.Append("PolylineId=@PolylineId");
                      
                       strSql.Append("AddTime=@AddTime");
                      
                    strSql.Append(" where Id=@Id");
                      
          
                SQLiteParameter[] parameters = {
                new SQLiteParameter("@Lat", DBNull.Value),
                new SQLiteParameter("@Lng", DBNull.Value),
                new SQLiteParameter("@Title", DBNull.Value),
                new SQLiteParameter("@Rank", DBNull.Value),
                new SQLiteParameter("@Intro", DBNull.Value),
                new SQLiteParameter("@PolylineId", DBNull.Value),
                new SQLiteParameter("@AddTime", DBNull.Value),
                new SQLiteParameter("@Id", DBNull.Value)
              };
                     parameters[0].Value = model.Lat;
                     parameters[1].Value = model.Lng;
                     parameters[2].Value = model.Title;
                     parameters[3].Value = model.Rank;
                     parameters[4].Value = model.Intro;
                     parameters[5].Value = model.PolylineId;
                     parameters[6].Value = model.AddTime;
                
                      parameters[7].Value = model.Id;
           

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }               
       }


         /// <summary>
       /// 分页列表
       /// </summary>
       public List<MarkerModel> MarkerList(Criteria c, int CurPage, int pageSize, out int OutCount)
       {
             string whereStr = c.GetWhere();
           object[] whereValueStr =c.GetWhereValue();
           string orderbyStr = c.GetOrderByString();
                if(!string.IsNullOrEmpty(orderbyStr))
           {
               orderbyStr = "order by " + orderbyStr;
           }
           List<MarkerModel> list = new List<MarkerModel>();

           StringBuilder str = new StringBuilder();
          
           SQLiteParameter[] paras = new SQLiteParameter[whereValueStr.Length+2];
           for (int i = 0; i < whereValueStr.Length;i++ )
           {
            paras[i] =  new SQLiteParameter("@"+i+"",whereValueStr[i].ToString());             
           }

           paras[whereValueStr.Length] = new SQLiteParameter("@start", (CurPage - 1) * pageSize);
           paras[whereValueStr.Length + 1] = new SQLiteParameter("@pageSize", pageSize);

           str.Append("select  * From Marker  where " + whereStr + " " + orderbyStr + " Limit @start,@pageSize");
           DataTable dt = new DataTable();
           dt = DbHelperSQLite.Query(str.ToString(), paras).Tables[0];
           list = ModelConvertHelper<MarkerModel>.ConvertToModel(dt).ToList();

           StringBuilder getCountStr = new StringBuilder();
           getCountStr.Append("select  count(*) From Marker  where " + whereStr);
           OutCount = Convert.ToInt32(DbHelperSQLite.Query(getCountStr.ToString(), paras).Tables[0].Rows[0][0]);
           return list;
       }
           /// <summary>
        /// 列表,不分页
        /// </summary>
          public List<MarkerModel> MarkerList(Criteria c)
        {
             string whereStr = c.GetWhere();
            object[] whereValueStr = c.GetWhereValue();
            string orderbyStr = c.GetOrderByString();
            if (!string.IsNullOrEmpty(orderbyStr))
            {
                orderbyStr = "order by " + orderbyStr;
            }
            List<MarkerModel> list = new List<MarkerModel>();

            StringBuilder str = new StringBuilder();

            SQLiteParameter[] paras = new SQLiteParameter[whereValueStr.Length];
            for (int i = 0; i < whereValueStr.Length; i++)
            {
                paras[i] = new SQLiteParameter("@" + i + "", whereValueStr[i].ToString());
            }

            str.Append("select  * From Marker  where " + whereStr + " " + orderbyStr);
            DataTable dt = new DataTable();
            dt = DbHelperSQLite.Query(str.ToString(), paras).Tables[0];
            list = ModelConvertHelper<MarkerModel>.ConvertToModel(dt).ToList();
            return list;
        }
            /// <summary>
        /// 取出总数
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int GetCount(Criteria c)
       {
          string whereStr = c.GetWhere();
           object[] whereValueStr = c.GetWhereValue();
           string orderbyStr = c.GetOrderByString();
           SQLiteParameter[] paras = new SQLiteParameter[whereValueStr.Length];
           for (int i = 0; i < whereValueStr.Length; i++)
           {
               paras[i] = new SQLiteParameter("@" + i + "", whereValueStr[i].ToString());
           }
           StringBuilder getCountStr = new StringBuilder();
           getCountStr.Append("select  count(*) From Marker  where " + whereStr);
           int count = Convert.ToInt32(DbHelperSQLite.Query(getCountStr.ToString(), paras).Tables[0].Rows[0][0]);
           return count;
           
       }
        /// <summary>
       /// 根据主键值取出数据
       /// </summary>
       public MarkerModel MarkerDetail(int? Id)
       {
         MarkerModel model = new MarkerModel();

           SQLiteParameter[] paras = {
                                     
            new SQLiteParameter("@Id",Id)
                                     };
           StringBuilder str = new StringBuilder();
           str.Append("select  * From Marker  where Id=@Id ");
           DataTable dt = new DataTable();
           dt = DbHelperSQLite.Query(str.ToString(), paras).Tables[0];
           model = ModelConvertHelper<MarkerModel>.ConvertToModel(dt).ToList().FirstOrDefault();
           return model;
       }
        /// <summary>
       /// 删除
       /// </summary>
          public bool DeleteMarker(int? Id)
       {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Marker ");
            strSql.Append(" where Id=@Id");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",Id)};
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
          
       }
       }
}