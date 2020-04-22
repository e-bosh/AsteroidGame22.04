﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidGame
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form game_form = new Form();
            //Screen.PrimaryScreen.WorkingArea
            game_form.Width = 800;
            game_form.Height = 600;

            game_form.Show();

            Game.Initialize(game_form);
            Game.Load();
            Game.Draw();

            Application.Run(game_form);

            

        }
    }
}
