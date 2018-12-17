using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class GameScreen: IRenderable
    {
        private int width;
        private int height;
        private Player player;

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        public void PlayersPritn(int p, int t)
        {

            player.StartGame(p,t);
        }

        public void Render()
        {
            player.PrintInfo();
        }

    }
}