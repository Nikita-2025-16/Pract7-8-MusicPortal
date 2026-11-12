using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MusicPortal.Pages
{
    public class AddTrackModel : PageModel
    {
        //  Поле для виконавця
        [BindProperty]
        [Required(ErrorMessage = "Поле 'Виконавець' є обов'язковим")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ім'я виконавця має містити від 2 до 50 символів")]
        public string Artist { get; set; } = string.Empty;

        //  Поле для назви треку
        [BindProperty]
        [Required(ErrorMessage = "Поле 'Назва треку' є обов'язковим")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Назва треку має містити від 2 до 100 символів")]
        public string Title { get; set; } = string.Empty;

        //  Поле для року випуску (Nullable int, щоб Required коректно працював, якщо поле порожнє)
        [BindProperty]
        [Required(ErrorMessage = "Будь ласка, вкажіть рік випуску")]
        [Range(1990, 2026, ErrorMessage = "Рік випуску має бути між 1990 та 2026")]
        public int? ReleaseYear { get; set; }

        //  Поле для Email
        [BindProperty]
        [Required(ErrorMessage = "Поле 'Email' є обов'язковим")]
        [EmailAddress(ErrorMessage = "Введіть коректну електронну адресу")]
        public string ContactEmail { get; set; } = string.Empty;

        // Властивість для зеленого повідомлення про успіх
        public string SuccessMessage { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Якщо є помилки - просто повертаємо сторінку назад (з'являться червоні тексти)
                return Page();
            }

            SuccessMessage = $"Дякуємо! Християнський трек '{Title}' від '{Artist}' успішно надіслано на модерацію. Ми зв'яжемося з вами за адресою {ContactEmail}.";

            return Page();
        }
    }
}