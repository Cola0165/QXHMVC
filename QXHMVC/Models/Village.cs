using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QXHMVC.Models
{
    public class Village
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "乡村名")]
        [Required(ErrorMessage = "这是必须项。")]
        [StringLength(10, ErrorMessage = "{0}最多为{1}个字符。")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "地址")]
        [Required(ErrorMessage = "这是必须项。")]
        [StringLength(50, ErrorMessage = "{0}最多为{1}个字符。")]
        [DataType(DataType.Text)]
        public string Addr { get; set; }

        [Display(Name = "需求")]
        [DataType(DataType.MultilineText)]
        public string Requ { get; set; }

        //[Display(Name ="附件")]
        //[FileExtensions(Extensions =".jpg,.png,.doc,.docx,.pdf,.zip,.rar",ErrorMessage ="格式错误")]
        //public HttpPostedFileBase File { get; set; }

        [DataType(DataType.Text)]
        public string userID { get; set; }
        
    }
}