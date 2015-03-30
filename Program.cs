using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeagueSharp;
using LeagueSharp.Common;



namespace Vkey
{
    class Program
    {
        public static LeagueSharp.Common.Menu _menu;
       // private static Obj_AI_Hero Player;
        static void Main(string[] args)
        {
            //CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            //Game.OnUpdate += Game_OnGameUpdate;

            //_menu = new Menu("Rockwang_Virtual_KeyDown", "vkd", true);
            //_menu.AddSubMenu(new Menu("Vkeydown_keybins", "vkd_kb"));
            //_menu.SubMenu("vkd_kb").AddSubMenu(new Menu("Key_one", "keyone"));
            //_menu.SubMenu("vkd_kb").SubMenu("key1").AddItem(new MenuItem("clckkey1", "key_one").SetValue(new KeyBind(57, KeyBindType.Press)));
            //_menu.SubMenu("vkd_kb").AddSubMenu(new Menu("Key_one", "vkey1"));
            //_menu.AddToMainMenu();






        }
        private static void Game_OnGameUpdate(EventArgs args)
        {

        }

    }
}
