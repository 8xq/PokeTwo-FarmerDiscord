using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTwoBot
{
    class Helper
    {
        #region Variables | set with json 
        public static string DiscordToken { get; set; }
        public static ulong ChannelID { get; set; }
        public static string CatchPrefix { get; set; }
        public static string HintPrefix { get; set; }
        public static string SpamChannelID { get; set; }
        #endregion
        #region Random char gen (random chat spam)
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion
        #region Load pokemon from file (get all names)
        public static List<string> Pokemon = new List<string>();
        public static string PokemonList = File.ReadAllText(@"PokemonList.txt");
        #endregion
    }
}
