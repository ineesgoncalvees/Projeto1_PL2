using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_LP2
{
    public class GamesInfo
    {
        public readonly string name;
        public readonly int id;
        public readonly int r_age;
        public readonly int dlc;
        public readonly int metacritic;
        public readonly int movie_count;
        public readonly int recommendation_count;
        public readonly int screenshot_count;
        public readonly int owners;
        public readonly int number_of_players;
        public readonly int achievement_count;
        public readonly bool controller_support;
        public readonly bool platform_windows;
        public readonly bool platform_linux;
        public readonly bool platform_mac;
        public readonly bool category_singleplayer;
        public readonly bool category_multiplayer;
        public readonly bool category_coop;
        public readonly bool category_include_level_editor;
        public readonly bool category_vr_support;
        public readonly string about_text;
        public readonly Uri support_URL;
        public readonly Uri header_image;
        public readonly Uri website;
        public readonly DateTime release_date;

        public GamesInfo(string s)
        {
            string[] parse = s.Split(',');
            id = Convert.ToInt32(parse[0]);
            name = parse[1];
            DateTime.TryParse(parse[2], out release_date);
            r_age = Convert.ToInt32(parse[3]);
            dlc = Convert.ToInt32(parse[4]);
            metacritic = Convert.ToInt32(parse[5]);
            movie_count = Convert.ToInt32(parse[6]);
            recommendation_count = Convert.ToInt32(parse[7]);
            screenshot_count = Convert.ToInt32(parse[8]);
            owners = Convert.ToInt32(parse[9]);
            number_of_players = Convert.ToInt32(parse[10]);
            achievement_count = Convert.ToInt32(parse[11]);
            controller_support = Convert.ToBoolean(parse[12]);
            platform_windows = Convert.ToBoolean(parse[13]);
            platform_linux = Convert.ToBoolean(parse[14]);
            platform_mac = Convert.ToBoolean(parse[15]);
            category_singleplayer = Convert.ToBoolean(parse[16]);
            category_multiplayer = Convert.ToBoolean(parse[17]);
            category_coop = Convert.ToBoolean(parse[18]);
            category_include_level_editor = Convert.ToBoolean(parse[19]);
            category_vr_support = Convert.ToBoolean(parse[20]);
            Uri.TryCreate(parse[21], UriKind.Absolute, out support_URL);
            about_text = parse[22];
            Uri.TryCreate(parse[23], UriKind.Absolute, out header_image);
            Uri.TryCreate(parse[24], UriKind.Absolute, out website);
        }

        public override string ToString()
        {
            return string.Format($"ID: {id}\nName: {name}\nRelease date: {release_date}\n" +
                $"Required age: {r_age}\nDLC count: {dlc}\nMetacritic: {metacritic}\n" +
                $"Movie count: {movie_count}\nRecommendation count: {recommendation_count}\n" +
                $"Screenshot count: {screenshot_count}\nOwners: {owners}\nNumber of players: " +
                $"{number_of_players}\nAchievement count: {achievement_count}\nController support: " +
                $"{controller_support}\nPlatform windows: {platform_windows}\nPlatform linux: " +
                $"{platform_linux}\nPlatform mac: {platform_mac}\nCategory singleplayer: " +
                $"{category_singleplayer}\nCategory multiplayer: {category_multiplayer}\n" +
                $"Category coop: {category_coop}\nCategory include level editor: " +
                $"{category_include_level_editor}\nCategory VR support: {category_vr_support}\n" +
                $"Support URL: {support_URL}\nAbout text: {about_text}\nHeader image: " +
                $"{header_image}\nWebsite: {website}");
        }
    }
}
