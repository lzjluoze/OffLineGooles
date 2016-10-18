////////////////////////////////////////////////
// 生成时间: 2016-10-18 09:22:51
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Text;

namespace Model
{

    public class MarkerModel
    {

        
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public Int64 Id
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public string Lat
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public string Lng
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public string Title
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public int? Rank
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public string Intro
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public int? PolylineId
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public DateTime? AddTime
        {
            set;
            get;
        }
        
         
             public const string _Id="Id";
             public const string _Lat="Lat";
             public const string _Lng="Lng";
             public const string _Title="Title";
             public const string _Rank="Rank";
             public const string _Intro="Intro";
             public const string _PolylineId="PolylineId";
             public const string _AddTime="AddTime";
           
        
    }
}