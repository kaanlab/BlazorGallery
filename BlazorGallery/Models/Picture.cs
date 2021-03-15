using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorGallery.Models
{
    public class Picture
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [MinLength(6, ErrorMessage = "Миннимальная длина 6 символов")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [MinLength(6, ErrorMessage = "Миннимальная длина 6 символов")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string VideoUrl { get; set; }
    }
}