using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MusicPortal.Pages
{
    public class PlaylistCalcModel : PageModel
    {
        [BindProperty]
        public int TracksCount { get; set; }

        [BindProperty]
        public int AverageDuration { get; set; }

        public string ResultMessage { get; set; } = string.Empty;

        public void OnPost()
        {
            int totalSeconds = TracksCount * AverageDuration;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            ResultMessage = $"Загальна тривалість: {minutes} хв {seconds} сек";
        }
    }
}