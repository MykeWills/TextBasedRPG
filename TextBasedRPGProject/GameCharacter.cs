using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    abstract class GameCharacter
    {
        
        private Map map;
        protected Tile avatar;
        protected string name;
        protected Point2D position;
        protected int health;
        public Point2D Position
        {
            get => position;
        }

        public void SetMap(Map map)
        {
            this.map = map;
        }
        public void TryMove(int dx, int dy)
        {
            if(!map.IsWall(position.x + dx, position.y + dy))
            {
                position.x += dx;
                position.y += dy;
            }
        }
        public GameCharacter()
        {
            Console.WriteLine("Game Character");
        }
        public void Draw(Render render)
        {
            render.Draw(avatar, position);
        }
    }
}
