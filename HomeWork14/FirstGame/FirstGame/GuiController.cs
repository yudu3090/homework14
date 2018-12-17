using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class GuiController
    {
        GameController gameController;
        GameWindow gameWindow;
        PlayersWindow playersWindow;
        CreditWindow creditWindow;
        PlayerTimes playerTimes;
        
       
        public GuiController()
        {
            //perkeliau is Program
            gameWindow = new GameWindow();
            creditWindow = new CreditWindow();
            gameController = new GameController();
            playersWindow = new PlayersWindow();
            playerTimes = new PlayerTimes();
        }

        public void NavigationMeniu()
        {
            Console.Clear();
            gameWindow.Render();
            bool exit = false;
            int active;
            do
            {
                //aktyvus pirmas meniu mygtukas
                ConsoleKey choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.RightArrow:
                        gameWindow.MoveArrow(false, true);
                        break;
                    case ConsoleKey.LeftArrow:
                        gameWindow.MoveArrow(true, false);
                        break;
                    case ConsoleKey.Enter:
                        active = gameWindow.Get();
                        if (active == 1)
                        {
                            CreditWindow();
                        }
                        else if (active == 2)
                        {
                            return;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
           
                Console.Clear();
                gameWindow.Render();
            } while (!exit);
        }

        public void CreditWindow()
        {
            Console.Clear();
            playersWindow.Render();
            bool exit = false;
            int active2;
            do
            {
                //aktyvus pirmas meniu mygtukas
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        playersWindow.MoveArrow(false, true, false, false);
                        break;
                    case ConsoleKey.LeftArrow:
                        playersWindow.MoveArrow(true, false, false, false);
                        break;
                    case ConsoleKey.DownArrow:
                        playersWindow.MoveArrow(false, false, false, true);
                        break;
                    case ConsoleKey.UpArrow:
                        playersWindow.MoveArrow(false, false, true, false);
                        break;
                    case ConsoleKey.Enter:
                        active2 = playersWindow.Get();
                        if (active2 == 1)
                        {
                            ChoiceWindow(active2);
                        }
                        else if (active2 == 2)
                        {
                            ChoiceWindow(active2);
                        }
                        else if (active2 == 3)
                        {
                            ChoiceWindow(active2);
                        }
                        if (active2 == 4)
                        {
                            ChoiceWindow(active2);
                        }
                        else if (active2 == 5)
                        {
                            ChoiceWindow(active2);
                        }
                        else if (active2 == 6)
                        {
                            ChoiceWindow(active2);
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                Console.Clear();
                playersWindow.Render();
            } while (!exit);
        }

        public void ChoiceWindow(int playersCount)
        {
            Console.Clear();
            playerTimes.Render();
            bool exit = false;
            int active2;
            do
            {
                //aktyvus pirmas meniu mygtukas
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        playerTimes.MakeChoice(false, true);
                        playerTimes.SetChoice();
                        playerTimes.Render();
                        break;
                    case ConsoleKey.LeftArrow:
                        playerTimes.MakeChoice(true, false);
                        playerTimes.SetChoice();
                        playerTimes.Render();
                        break;
                    case ConsoleKey.Enter:
                        active2 = playerTimes.Get();
                        gameController.StartGame(playersCount+1, active2);
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                Console.Clear();
                playerTimes.Render();
            } while (!exit);
        }
    }
}


