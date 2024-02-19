using FitnessFrogDb.Models;

namespace FitnessFrog.Models;

public class EntriesIndexViewModel
    {
        public EntriesIndexViewModel()
        {
            Entries = [];
        }

        public IList<Entry> Entries { get; set; }
        public decimal TotalActivity { get; set; }
        public decimal AverageDailyActivity { get; set; }
    }