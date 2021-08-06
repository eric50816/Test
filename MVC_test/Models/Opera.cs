using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_test.Models
{
    public class Opera
    {
        [DisplayName("編號")]
        public int OperaID { get; set; }
        [Required(ErrorMessage = "歌劇名稱不可為空白")]
        [StringLength(200)]
        [DisplayName("歌劇名稱")]
        public string Title { get; set; }
        [DisplayName("年代")]
        public int Year { get; set; }
        [Required]
        [DisplayName("作者")]
        public string Composer { get; set; }
    }
}