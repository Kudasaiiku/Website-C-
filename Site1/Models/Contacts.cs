using System.ComponentModel.DataAnnotations;

namespace Site1.Models
{
    public class Contacts
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Обязательно введите имя!")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Обязательно введите фамилию!")]
        public string Surname { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Обязательно введите возраст!")]
        public int Age { get; set; }

        [Display(Name = "Электронная почта")]
        [Required(ErrorMessage = "Обязательно введите электронную почту!")]
        public string Email { get; set; }

        [Display(Name = "Сообщение")]
        [Required(ErrorMessage = "Обязательно введите сообщение!")]
        [StringLength(30, ErrorMessage = "Текст менее 30 символов!")]
        public string Message { get; set; }

        [Display(Name = "Смайлик!")]
        [Required(ErrorMessage = "Обязательно введите смайлик!")]
        public string Emoji { get; set; }
    }
}
