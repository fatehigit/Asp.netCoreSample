using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace DigiKala.Core.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [MaxLength(11, ErrorMessage = "مقدار {0} نباید بیش تر از {1} کاراکتر باشد")]
        [MinLength(11, ErrorMessage = "مقدار {0} نباید کم تر از {1} کاراکتر باشد")]
        [Phone(ErrorMessage = "فقط عدد می توانید وارد کنید")]
        public string Mobile { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نباید بیش تر از {1} کاراکتر باشد")]
        [MinLength(4, ErrorMessage = "مقدار {0} نباید کم تر از {1} کاراکتر باشد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تایید کلمه عبور")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نباید بیش تر از {1} کاراکتر باشد")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "کلمه های عبور همخوانی ندارند")]
        public string ConfirmPassword { get; set; }
    }
}
