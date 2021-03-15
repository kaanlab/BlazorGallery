using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGallery.Models
{
    public class Intro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string VideoUrl { get; set; }

        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [MinLength(10, ErrorMessage = "Миннимальная длина 10 символов")]
        public string Text { get; set; }
    }
}
