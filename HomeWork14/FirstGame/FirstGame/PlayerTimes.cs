using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    sealed class PlayerTimes : Window, IRenderable
        {
            private Button startButton;
            private Button creditsButton;
            private Button info;
            private TextBlock titleTextBlock;
            public List<Button> playersTButtonsList;
            private int isActive2;

            public PlayerTimes() : base(0, 0, 120, 30, '%')
            {
                titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "How many times", "do you need?", "Vilnius Coding School!" });
                startButton = new Button(30, 13, 20, 5, "-");
                creditsButton = new Button(70, 13, 20, 5, "+");
                playersTButtonsList = new List<Button>() { };
                playersTButtonsList.Add(startButton);
                playersTButtonsList.Add(creditsButton);
                Render();
            }

            public override void Render()
            {
                base.Render();
                titleTextBlock.Render();
                foreach (Button button in playersTButtonsList)
                {
                    button.Render();
                }
                Enable();
                Console.SetCursorPosition(0, 0);
            }

            private void Enable()
            {
                for (int i = 0; i < playersTButtonsList.Count; i++)
                {
                    if (i == isActive2)
                    {
                        playersTButtonsList[i].Enable();
                    }
                    else
                    {
                        playersTButtonsList[i].Disable();
                    }
                }
            }

            public int Get()
            {
                return isActive2;
            }

            public void SetChoice()
            {
                info = new Button(50, 13, 20, 5, Convert.ToString(isActive2)+" times.");
                playersTButtonsList.Add(info);
                info.Render();
            }

            public void MakeChoice(bool left, bool right)
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
    

