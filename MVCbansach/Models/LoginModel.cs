using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCbansach.Models
{
    public class LoginModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage="Vui lòng nhập tên tài khoản")]
        [MinLength(3)]
        [MaxLength(20)]
        [Display(Name="Tên tài khoản")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [MinLength(3)]
        [MaxLength(20)]
        [Display(Name="Mật khẩu")]
        public string Password { get; set; }
    }
}