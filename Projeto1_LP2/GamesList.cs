using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_LP2
{
    public class GamesList : GamesInfo
    {
        List<GamesInfo> lst = new List<GamesInfo>();

        public void AddGames()
        {
            lst.Add(new GamesInfo(name, id, r_age, dlc, metacritic, movie_count,
                    recommendation_count, screenshot_count, owners,
                    number_of_players, achievement_count, controller_support,
                    platform_windows, platform_linux, platform_mac,
                    category_singleplayer, category_multiplayer, category_coop,
                    category_include_level_editor, category_vr_support,
                    about_text, support_URL, header_image, website,
                    release_date));

            

        }
    }
}
