using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Business
{
    public class Rover
    {
        public int x;  //x coordinate
        public int y;  //y coordintate
        public string Direction; //cardinal direction

        public Rover(string _location) //_location = {1 2 N}
        {
            Int32.TryParse(_location.Split(" ")[0], out x); // pick out string input of x
            Int32.TryParse(_location.Split(" ")[1], out y); //pick out string input of y
            Direction = _location.Split(" ")[2];  // pick out string input of direction
        }


        public void SpinLeft()
        {
            switch (Direction)
            {
                case "N": //Rover spin left N => W
                    Direction = "W";
                    break;
                case "E": //Rover spin left E => N
                    Direction = "N";
                    break;
                case "S": //Rover spin left S => E
                    Direction = "E";
                    break;
                case "W": //Rover spin left W => S
                    Direction = "S";
                    break;
                default:
                    throw new Exception("Direction is not valid");
            }
        }

        public void SpinRight()
        {
            switch (Direction)
            {
                case "N": //Rover spin right N => E
                    Direction = "E";
                    break;
                case "E": //Rover spin right E => S
                    Direction = "S";
                    break;
                case "S": //Rover spin right S => W
                    Direction = "W";
                    break;
                case "W": //Rover spin right W => N
                    Direction = "N";
                    break;
                default:
                    throw new Exception("Direction is not valid");
            }
        }

        
        public void MoveForward()
        {
            switch (Direction)
            {
                case "N": //Rover move forward N => y+1
                    y += 1;
                    break;
                case "E": //Rover move forward E => x+1
                    x += 1;
                    break;
                case "S": //Rover move forward S => y-1
                    y -= 1;
                    break;
                case "W": //Rover move forward W => x-1
                    x -= 1;
                    break;
                default:
                    throw new Exception("Direction is not valid");
            }
        }

        public void GoToLocation(string roverCommand)
        {
            //Get instructions from string provided.
            char[] intructions = roverCommand.ToCharArray();

            //Iterate through array of string for each char, then call SpinLeft,SpinRight,MoveForward based on intruction.
            for(int i=0;i<intructions.Length;i++)
            {
                switch (intructions[i].ToString())
                {
                    case "L": //When instructed to move Left
                        SpinLeft();
                        break;
                    case "R":  //When instructed to move Right
                        SpinRight();
                        break;
                    case "M":  //When instructed to move Move Forward
                        MoveForward();
                        break;
                    default:
                        throw new Exception("Instruction is not valid");
                }
            }

        }

    }
}
