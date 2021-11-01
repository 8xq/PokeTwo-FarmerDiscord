using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Discord;
using Discord.Gateway;
using System.IO;
using System.Text.RegularExpressions;
using Leaf.xNet;
using Newtonsoft.Json;

namespace PokeTwoBot
{
    public partial class PoketwoBot : Form
    {
        // Add UI (list view) to show caught pokemon | parse url of embed 
        // List total stats (legends , mythical , catch per hour etc)
        // Configure random delay / success rate for catch (humanize)
        #region Initialize & disable cross threads
        public PoketwoBot()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            PokeBotLog.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            PokeBotLog.Items.Add("Welcome to poke-two farmer");
            PokeBotLog.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        #endregion
        #region Moveable title bar (imports also)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #region On message event | Check message for poketwobot | parse pokemon
        private void OnMessageReceived(DiscordSocketClient client, MessageEventArgs args)
        {
            try
            {
                if (args.Message.Content == "!spamPokey")
                {
                    new Thread(() =>
                    {
                        while (true)
                        {
                            args.Message.Channel.SendMessage(Helper.RandomString(20));
                            Thread.Sleep(7500);
                        }
                    }).Start();
                }
                if (args.Message.Channel.Id != Helper.ChannelID) return;
                if (args.Message.Content.Contains("The pokémon is"))
                {
                    string PokemonHint = args.Message.Content.Replace(".", "").Replace("_", ".").Replace("The pokémon is ", "").Replace("\\", "");
                    Match m = Regex.Match(Helper.PokemonList, PokemonHint, RegexOptions.IgnoreCase);
                    if (m.Success)
                    {
                        string Catch = Helper.CatchPrefix + m.Value.ToString();
                        args.Message.Channel.SendMessage(Catch);
                        PokeBotLog.Items.Add($"Attempting to catch " + m.Value);
                        Console.WriteLine(args.Message.Content);
                    }
                }
                if (args.Message.Embed.Title.Contains("wild pokémon has appeared!"))
                {
                    PokeBotLog.Items.Add($"Wild pokemon appeared | requesting hint");
                    args.Message.Channel.SendMessage(Helper.HintPrefix);
                }
            }
            catch (Exception ex) { }
        }
        #endregion
        #region (On logged in event handler)
        private void OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
        {
            try
            {
                PokeBotLog.Items.Add($"Connected to {args.User}");
                Helper.Pokemon = File.ReadLines(@"PokemonList.txt").Distinct().ToList();
                PokeBotLog.Items.Add($"Loaded {Helper.Pokemon.Count()} pokemon names !");
            }
            catch (Exception)
            {
                PokeBotLog.Items.Add($"Error on connection !");
            }
        }
        #endregion
        #region Start button (start poke-two) farm bot
        private void StartFarmer_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                if (File.Exists(@"Config.json"))
                {
                    string ConfigFile = System.IO.File.ReadAllText(@"Config.json");
                    dynamic Key = JsonConvert.DeserializeObject(ConfigFile);
                    Helper.DiscordToken = Key.DiscordToken;
                    Helper.CatchPrefix = Key.CatchPrefix;
                    Helper.ChannelID = Key.ChannelID;
                    Helper.HintPrefix = Key.HintPrefix;
                    try
                    {
                        DiscordSocketClient client = new DiscordSocketClient();
                        client.OnLoggedIn += OnLoggedIn;
                        client.OnMessageReceived += OnMessageReceived;
                        client.Login(Helper.DiscordToken);
                    }
                    catch (Exception)
                    {
                        PokeBotLog.Items.Add($"Error creating new client / connecting with token !");
                    }
                }
                else
                {
                    MessageBox.Show("Could not locate config.json", "Error");
                }
            }).Start();
        }
        #endregion
    }
}
