////////////////////////////////////////////////
// 生成时间: 2016-10-18 09:22:52
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Text;

namespace Model
{

    public class PolylineModel
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
        public string Name
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
         // [Display(Name = " ")]
       // [Required(ErrorMessage = "{0}")]
        public string Color
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
             public const string _Name="Name";
             public const string _Color="Color";
             public const string _AddTime="AddTime";
           
        
    }
}