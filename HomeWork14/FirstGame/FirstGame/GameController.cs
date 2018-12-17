using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class GameController
    {
        GuiController guiController;

        public void StartGame(int players, int times)

        {
            guiController = new GuiController();
            GameScreen myGame = new GameScreen(40, 50);
            myGame.SetPlayer(new Player(players, times, "Thorr"));
            Random rnd = new Random();
            bool needToRender = true;
            Console.Clear();

            myGame.PlayersPritn(players, times);
            do
                {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.R:
                            guiController.CreditWindow();
                            break;
                        case ConsoleKey.Q:
                            guiController.NavigationMeniu();
                            break;
                    }
                }

                System.Threading.Thread.Sleep(250);
            }
            while (needToRender);
        }
    }
}
