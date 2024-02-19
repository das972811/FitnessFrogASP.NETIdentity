namespace FitnessFrog.Models;

public class EntriesAddViewModel : EntriesBaseViewModel
    {
        public EntriesAddViewModel()
        {
            Entry.Date = DateTime.Today;
        }
    }