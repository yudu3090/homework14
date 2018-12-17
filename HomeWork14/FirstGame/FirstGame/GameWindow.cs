using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    sealed class GameWindow : Window, IRenderable
    {
        private Button startButton;
        private Button creditsButton;
        private Button quitButton;
        private TextBlock titleTextBlock;
        public List<Button> buttonsList;
        private int isActive;

        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "My first game", "Yuliya Duniak", "Vilnius Coding School!" });
            startButton = new Button(40, 13, 15, 5, "  Start");
            quitButton = new Button(60, 13, 15, 5, "  Quit");
            buttonsList = new List<Button>() { };
            buttonsList.Add(startButton);     
            buttonsList.Add(quitButton);   
            Render();
        }

        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();
            
            foreach (Button button in buttonsList)
            {
                button.Render();               
            }
            Enable();
            Console.SetCursorPosition(0, 0);
        }

        private void Enable()
        {
            for (int i = 0; i < buttonsList.Count; i++)
            {
                if (i == isActive)
                {
                    buttonsList[i].Enable();
                }

                else
                {
                    buttonsList[i].Disable();
                }
            }
        }

        public int Get()
        {
            return isActive;
        }

        public void MoveArrow(bool left, bool right)
        {
            if (left)
            {
                if (isActive < 1)
                {
                    isActive = 1;
                }
                else
                {
                    isActive = isActive - 1;
                }
            }
            else if (right)
            {
                if (isActive > 2)
                {
                    isActive = 2;
                }
                isActive = isActive + 1;
            }
        }    
    }
}
