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

        public GamesInfo(string name, int id, int r_age, int dlc,
                    int metacritic, int movie_count, int recommendation_count,
                    int screenshot_count, int owners, int number_of_players,
                    int achievement_count, bool controller_support,
                    bool platform_windows, bool platform_linux, bool platform_mac,
                    bool category_singleplayer, bool category_multiplayer,
                    bool category_coop, bool category_include_level_editor,
                    bool category_vr_support, string about_text, Uri support_URL,
                    Uri header_image, Uri website, DateTime release_date)
        {
            this.name = name;
            this.id = id;
            this.release_date = release_date;
            this.r_age = r_age;
            this.dlc = dlc;
            this.metacritic = metacritic;
            this.movie_count = movie_count;
            this.recommendation_count = recommendation_count;
            this.screenshot_count = screenshot_count;
            this.owners = owners;
            this.number_of_players = number_of_players;
            this.achievement_count = achievement_count;
            this.controller_support = controller_support;
            this.platform_windows = platform_windows;
            this.platform_mac = platform_mac;
            this.platform_linux = platform_linux;
            this.category_singleplayer = category_singleplayer;
            this.category_multiplayer = category_multiplayer;
            this.category_coop = category_coop;
            this.category_include_level_editor = category_include_level_editor;
            this.category_vr_support = category_vr_support;
            this.support_URL = support_URL;
            this.about_text = about_text;
            this.header_image = header_image;
            this.website = website;
        }
    }
}
