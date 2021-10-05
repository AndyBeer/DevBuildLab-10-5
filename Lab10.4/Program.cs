using System;

namespace Lab10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //0. Welcome user to Room Calculator
            //1. Get user input (it will come in as a string) for length, width, height of room
            //2. Convert inputs into doubles (since it wouldnt always be a whole #)
            //3. Run the formula to calculate area, perimeter, number of paint cans and tiles needed
            //4. Print the results to the console.
            //5. Once complete w calculations, prompt user to continue
            //6. If user wants to continue, allow recalculations, repeat steps 1-5.  If not, end.

            //NOTE: Paint calculated for sq ft of 4 walls + ceiling


            //0
            Console.WriteLine("Welcome to the Grand Circus Room Calculator");

            //6
            bool userInput = true;

            while (userInput)
            {
                //1 and 2
                Console.WriteLine("Please enter room dimensions.");
                Console.Write("Enter Length: ");
                double roomLength = double.Parse(Console.ReadLine());

                Console.Write("Enter Width:  ");
                double roomWidth = double.Parse(Console.ReadLine());

                Console.Write("Enter Height: ");
                double roomHeight = double.Parse(Console.ReadLine());

                //3
                double roomFloorArea = roomLength * roomWidth;
                double roomPerimeter = (roomLength * 2) + (roomWidth * 2);
                double roomWallsArea = ((roomLength * roomHeight) * 2) + ((roomWidth * roomHeight) * 2);
                double roomPaintArea = roomFloorArea + roomWallsArea;
                double carpetTiles = (roomFloorArea / 5);
                double paintCans = (roomPaintArea / 5);
                double volumeRoom = (roomLength * roomWidth * roomHeight);

                //4
                Console.WriteLine($"Area:         {roomFloorArea}");
                Console.WriteLine($"Perimeter:    {roomPerimeter}");
                Console.WriteLine($"Room Volume:  {volumeRoom}");
                Console.WriteLine($"Carpet Tiles: {carpetTiles}");
                Console.WriteLine($"Paint Cans:   {paintCans}");
                
                //5
                Console.Write("Continue?  Y/N: ");
                string anotherRoom = (Console.ReadLine());
                anotherRoom.ToLower();

                if (anotherRoom == "y")
                {
                    userInput = true;
                }
                else
                {
                    userInput = false;
                }

            }

            
        }
    }
    
}
