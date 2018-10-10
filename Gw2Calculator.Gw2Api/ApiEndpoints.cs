using System.Collections.Generic;

namespace Gw2Calculator.Gw2Api
{
    public static class ApiEndpoints
    {
        public static string ItemStats => "/v2/itemstats";
        public static string Professions => "/v2/professions";
        public static string Skills => "/v2/skills";

        public static string ItemsStats(IEnumerable<string> ids)
        {
            var csv = string.Join(',', ids);
            return $"{ItemStats}?ids={csv}";
        }

        public static string Profession(string profession)
        {
            return $"{Professions}/{profession}";
        }

        public static string Skill(IEnumerable<string> ids)
        {
            var csv = string.Join(',', ids);
            return $"{Skills}?ids={csv}";
        }
    }
}
