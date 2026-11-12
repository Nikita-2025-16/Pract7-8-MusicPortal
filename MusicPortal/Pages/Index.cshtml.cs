using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MusicPortal.Pages
{
    // Модель для одного треку
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
    }

    public class IndexModel : PageModel
    {
        public List<Song> Songs { get; set; } = new List<Song>();

        public void OnGet()
        {
            // Наш топ-10 українських християнських пісень
            Songs = new List<Song>
            {
                new Song { Id = 1, Artist = "IFOUND", Title = "Не зупиняйся", Genre = "Worship", Duration = "04:12" },
                new Song { Id = 2, Artist = "M.Worship", Title = "Ти зі мною", Genre = "Worship", Duration = "05:30" },
                new Song { Id = 3, Artist = "Spasinnya Music", Title = "Навіки", Genre = "Християнський рок", Duration = "04:45" },
                new Song { Id = 4, Artist = "NG Youth", Title = "Бог є любов", Genre = "Інді-поп", Duration = "03:55" },
                new Song { Id = 5, Artist = "Room For More", Title = "Океан", Genre = "Worship", Duration = "06:10" },
                new Song { Id = 6, Artist = "4UBAND", Title = "Він живий", Genre = "Поп-рок", Duration = "03:40" },
                new Song { Id = 7, Artist = "Imprintband", Title = "Світло", Genre = "Worship", Duration = "04:20" },
                new Song { Id = 8, Artist = "Hillsong Kyiv", Title = "Довіряю", Genre = "Прославлення", Duration = "05:15" },
                new Song { Id = 9, Artist = "SokolovBrothers", Title = "Твоя любов", Genre = "Християнський рок", Duration = "04:05" },
                new Song { Id = 10, Artist = "Zion", Title = "Алілуя", Genre = "Worship", Duration = "04:50" }
            };
        }
    }
}