namespace Gw2Calculator.Gw2Api
{
    public static class ApiEndpoints
    {
        public static string Professions => "/v2/professions";

        public static string Profession(string profession)
        {
            return $"{Professions}/{profession}";
        }
    }
}
