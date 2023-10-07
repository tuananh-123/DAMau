using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_Dtos.AuthenticationDtos
{
    public class UserLoginInformation
    {
        [Required(ErrorMessage = "Không đươc bỏ trống thông tin email")]
        [RegularExpression("/^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$/", ErrorMessage = "Email không hơp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống mật khẩu")]
        public string Password { get; set; }
    }
}
