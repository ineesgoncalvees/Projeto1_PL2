using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto1_LP2
{
    public class GamesList : List<GamesInfo>
    {
        public GamesList(string args)
        {
            AddGames(args);
        }

        public void AddGames(string args)
        {
            using (StreamReader sr = new StreamReader(args))
            {
                string info = "";
                GamesInfo gi = null;
                int srl = 0;
                
                while((info = sr.ReadLine()) != null)
                {
                    string[] parse = info.Split(',');
                    bool id_exists = false;
                    if (srl != 0)
                    {
                        gi = new GamesInfo(info);

                        foreach (GamesInfo g_info in this)
                        {
                            if (g_info.id == gi.id)
                            {
                                id_exists = true;
                            }
                        }

                        if (!id_exists)
                        {
                            Add(gi);
                        }
                    }
                    srl++;
                }
            }

        }
    }
}
