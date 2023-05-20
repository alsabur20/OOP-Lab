using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.BL
{
    class GameObject
    {
        public char[,] shape;
        public Point StartingPoint;
        public Boundary premises;
        public string direction;
        public string direction2;
        public string direction3;
        public int count;
        public GameObject()
        {
            shape = new char[,] { { '-', '-', '-' } };
            StartingPoint = new Point();
            premises = new Boundary();
            direction = "LeftToRight";
            direction2 = "RightToLeft";
            direction3 = "TopRight";
            count = 0;
        }
        public GameObject(char[,] shape, Point StartingPoint)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            direction2 = "RightToLeft";
            count = 0;
            direction3 = "TopRight";

        }
        public GameObject(char[,] shape, Point StartingPoint, Boundary premises, string direction)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            this.premises = premises;
            this.direction = direction;
            direction2 = "RightToLeft";
            count = 0;
            direction3 = "TopRight";

        }

        public void Move()
        {

            if (direction == "LeftToRight")
            {
                if (StartingPoint.GetX() == (premises.TopRight.GetX() - shape.GetLength(1)))
                {
                    StartingPoint.SetX(premises.TopRight.GetX() - shape.GetLength(1));
                }
                else
                {
                    StartingPoint.SetX(StartingPoint.GetX() + 1);
                }
            }
            else if (direction == "RightToLeft")
            {
                if (StartingPoint.GetX() == premises.TopLeft.GetX())
                {
                    StartingPoint.SetX(0);
                }
                else
                {
                    StartingPoint.SetX(StartingPoint.GetX() - 1);
                }
            }
            else if (direction == "Patrol")
            {

                if (StartingPoint.GetX() == premises.TopLeft.GetX() || StartingPoint.GetX() == premises.TopRight.GetX())
                {
                    ChangeDirection();
                }
                if (direction2 == "RightToLeft")
                {
                    StartingPoint.SetX(StartingPoint.GetX() - 1);
                }
                else if (direction2 == "LeftToRight")
                {
                    StartingPoint.SetX(StartingPoint.GetX() + 1);
                }
            }
            else if (direction == "Projectile")
            {
                if (direction3 == "TopRight" && count < 5)
                {
                    if (StartingPoint.GetX()+shape.GetLength(0) < premises.TopRight.GetX() && StartingPoint.GetY() > premises.TopRight.GetY())
                    {
                        StartingPoint.SetX(StartingPoint.GetX() + 1);
                        StartingPoint.SetY(StartingPoint.GetY() - 1);
                        count++;
                    }
                    else
                    {
                        StartingPoint.SetX(StartingPoint.GetX());
                        StartingPoint.SetY(StartingPoint.GetY());
                    }
                }
                else if (direction3 == "Right" && count < 7)
                {
                    StartingPoint.SetX(StartingPoint.GetX() + 1);
                    count++;
                }
                else if (direction3 == "BottomRight" && count < 11)
                {
                    StartingPoint.SetX(StartingPoint.GetX() + 1);
                    StartingPoint.SetY(StartingPoint.GetY() + 1);
                    count++;
                }
                if (count == 5)
                {
                    direction3 = "Right";
                }
                if (count == 7)
                {
                    direction3 = "BottomRight";
                }
            }
            else if (direction == "Diagonal")
            {
                if (StartingPoint.x < 90 - shape.GetLength(1) && StartingPoint.y < 90 - shape.GetLength(0))
                {
                    StartingPoint.SetX(StartingPoint.GetX() + 1);
                    StartingPoint.SetY(StartingPoint.GetY() + 1);
                }
            }
        }
        public void Erase()
        {
            int y = StartingPoint.GetY();
            int x = StartingPoint.GetX();
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.Write(" ");
                }
                y++;
            }
        }
        public void Draw()
        {
            int y = StartingPoint.GetY();
            int x = StartingPoint.GetX();
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.Write(shape[i, j]);
                }
                y++;
            }
        }
        public void ChangeDirection()
        {
            if (direction2 == "LeftToRight")
            {
                direction2 = "RightToLeft";
            }
            else if (direction2 == "RightToLeft")
            {
                direction2 = "LeftToRight";
            }
        }
    }
}
