namespace Covid_Api_Project.Model
{
    public class CovidData
    {
        public string Country { get; set; }
        public long Cases { get; set; }
        public long TodayCases { get; set; }
        public long Deaths { get; set; }
        public long TodayDeaths { get; set; }
        public long Recovered { get; set; }
        public long Active { get; set; }
        public long Critical { get; set; }
        public long CasesPerOneMillion { get; set; }
        public long DeathsPerOneMillion { get; set; }
        public long Tests { get; set; }
        public long TestsPerOneMillion { get; set; }
        public long Population { get; set; }
    }
}
