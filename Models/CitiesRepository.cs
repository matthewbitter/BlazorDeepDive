namespace BlazorDeepDive.Models
{
    public static class CitiesRepository
    {

        private static List<String> cities = new List<String>()
        {
            "Toronto",
            "Montreal",
            "Ottawa",
            "Calgary",
            "Halifax"
        };

        public static IEnumerable<String> GetCities()
        {
            return cities;
        }

    }
}
