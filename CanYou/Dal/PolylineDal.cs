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
    public class PolylineDal
    {
  
         /// <summary>
       /// 添加
       /// </summary>
       public bool AddPolyline(PolylineModel model)
       {

          
        
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Polyline(");
            strSql.Append("Name,Color,AddTime)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Color,@AddTime)");
             SQLiteParameter[] parameters = {
                new  SQLiteParameter("@Name", DBNull.Value),
                new  SQLiteParameter("@Color", DBNull.Value),
                  new  SQLiteParameter("@AddTime", DBNull.Value)
              };
                    parameters[0].Value = model.Name;
                    parameters[1].Value = model.Color;
                    parameters[2].Value = model.AddTime;

              
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
       public bool UpdataPolyline(PolylineModel model)
       {
 StringBuilder strSql = new StringBuilder();
           strSql.Append("update Polyline set ");
                      strSql.Append("Name=@Name,");
                       strSql.Append("Color=@Color");
                      
                       strSql.Append("AddTime=@AddTime");
                      
                    strSql.Append(" where Id=@Id");
                      
          
                SQLiteParameter[] parameters = {
                new SQLiteParameter("@Name", DBNull.Value),
                new SQLiteParameter("@Color", DBNull.Value),
                new SQLiteParameter("@AddTime", DBNull.Value),
                new SQLiteParameter("@Id", DBNull.Value)
              };
                     parameters[0].Value = model.Name;
                     parameters[1].Value = model.Color;
                     parameters[2].Value = model.AddTime;
                
                      parameters[3].Value = model.Id;
           

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
       public List<PolylineModel> PolylineList(Criteria c, int CurPage, int pageSize, out int OutCount)
       {
             string whereStr = c.GetWhere();
           object[] whereValueStr =c.GetWhereValue();
           string orderbyStr = c.GetOrderByString();
                if(!string.IsNullOrEmpty(orderbyStr))
           {
               orderbyStr = "order by " + orderbyStr;
           }
           List<PolylineModel> list = new List<PolylineModel>();

           StringBuilder str = new StringBuilder();
          
           SQLiteParameter[] paras = new SQLiteParameter[whereValueStr.Length+2];
           for (int i = 0; i < whereValueStr.Length;i++ )
           {
            paras[i] =  new SQLiteParameter("@"+i+"",whereValueStr[i].ToString());             
           }

           paras[whereValueStr.Length] = new SQLiteParameter("@start", (CurPage - 1) * pageSize);
           paras[whereValueStr.Length + 1] = new SQLiteParameter("@pageSize", pageSize);

           str.Append("select  * From Polyline  where " + whereStr + " " + orderbyStr + " Limit @start,@pageSize");
           DataTable dt = new DataTable();
           dt = DbHelperSQLite.Query(str.ToString(), paras).Tables[0];
           list = ModelConvertHelper<PolylineModel>.ConvertToModel(dt).ToList();

           StringBuilder getCountStr = new StringBuilder();
           getCountStr.Append("select  count(*) From Polyline  where " + whereStr);
           OutCount = Convert.ToInt32(DbHelperSQLite.Query(getCountStr.ToString(), paras).Tables[0].Rows[0][0]);
           return list;
       }
           /// <summary>
        /// 列表,不分页
        /// </summary>
          public List<PolylineModel> PolylineList(Criteria c)
        {
             string whereStr = c.GetWhere();
            object[] whereValueStr = c.GetWhereValue();
            string orderbyStr = c.GetOrderByString();
            if (!string.IsNullOrEmpty(orderbyStr))
            {
                orderbyStr = "order by " + orderbyStr;
            }
            List<PolylineModel> list = new List<PolylineModel>();

            StringBuilder str = new StringBuilder();

            SQLiteParameter[] paras = new SQLiteParameter[whereValueStr.Length];
            for (int i = 0; i < whereValueStr.Length; i++)
            {
                paras[i] = new SQLiteParameter("@" + i + "", whereValueStr[i].ToString());
            }

            str.Append("select  * From Polyline  where " + whereStr + " " + orderbyStr);
            DataTable dt = new DataTable();
            dt = DbHelperSQLite.Query(str.ToString(), paras).Tables[0];
            list = ModelConvertHelper<PolylineModel>.ConvertToModel(dt).ToList();
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
           getCountStr.Append("select  count(*) From Polyline  where " + whereStr);
           int count = Convert.ToInt32(DbHelperSQLite.Query(getCountStr.ToString(), paras).Tables[0].Rows[0][0]);
           return count;
           
       }
        /// <summary>
       /// 根据主键值取出数据
       /// </summary>
       public PolylineModel PolylineDetail(int? Id)
       {
         PolylineModel model = new PolylineModel();

           SQLiteParameter[] paras = {
                                     
            new SQLiteParameter("@Id",Id)
                                     };
           StringBuilder str = new StringBuilder();
           str.Append("select  * From Polyline  where Id=@Id ");
           DataTable dt = new DataTable();
           dt = DbHelperSQLite.Query(str.ToString(), paras).Tables[0];
           model = ModelConvertHelper<PolylineModel>.ConvertToModel(dt).ToList().FirstOrDefault();
           return model;
       }
        /// <summary>
       /// 删除
       /// </summary>
          public bool DeletePolyline(int? Id)
       {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Polyline ");
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