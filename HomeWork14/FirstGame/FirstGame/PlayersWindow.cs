using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    sealed class PlayersWindow : Window, IRenderable
    {
        private Button startButton;
        private Button creditsButton;
        private Button quitButton;
        private Button startButton2;
        private Button creditsButton2;
        private Button quitButton2;
        private TextBlock titleTextBlock;
        public List<Button> playersButtonsList;
        private int isActive2;

        public PlayersWindow() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "My first game", "Yuliya Duniak", "Vilnius Coding School!" });
            startButton = new Button(30, 13, 20, 5, "P2");
            creditsButton = new Button(50, 13, 20, 5, "P3");
            quitButton = new Button(70, 13, 20, 5, "P4");
            startButton2 = new Button(30, 18, 20, 5, "P5");
            creditsButton2 = new Button(50, 18, 20, 5, "P6");
            quitButton2 = new Button(70, 18, 20, 5, "P7");
            playersButtonsList = new List<Button>() { };
            playersButtonsList.Add(startButton);
            playersButtonsList.Add(creditsButton);
            playersButtonsList.Add(quitButton);
            playersButtonsList.Add(startButton2);
            playersButtonsList.Add(creditsButton2);
            playersButtonsList.Add(quitButton2);
            Render();
        }

        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();

            foreach (Button button in playersButtonsList)
            {
                button.Render();
            }
            Enable();
            Console.SetCursorPosition(0, 0);
        }

        private void Enable()
        {
            for (int i = 0; i < playersButtonsList.Count; i++)
            {
                if (i == isActive2)
                {
                    playersButtonsList[i].Enable();
                }

                else
                {
                    playersButtonsList[i].Disable();
                }
            }
        }

        public int Get()
        {
            return isActive2;
        }

        public void MoveArrow(bool left, bool right, bool up, bool down)
        {
            if (down)
            {
                if (left)
                {
                    isActive2 = isActive2 - 1;
                    if (isActive2 < 1)
                    {
                        isActive2 = 1;
                    }
                }
                else if (right)
                {
                    isActive2 = isActive2 + 1;
                    if (isActive2 > 6)
                    {
                        isActive2 = 6;
                    }
                }
            }
            else
            {
                if (left)
                {
                    isActive2 = isActive2 - 1;
                    if (isActive2 < 1)
                    {
                        isActive2 = 1;
                    }
                }
                else if (right)
                {
                    isActive2 = isActive2 + 1;
                    if (isActive2 > 6)
                    {
                        isActive2 = 6;
                    }
                }
            }

        }
    }
}
