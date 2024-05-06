using RubiksCube.Classes;
using RubiksCube.Enums;
using System;

namespace RubiksCube.Helpers
{
    public class PrintHelper
    {
        /* Prints a matrix representation of the Rubik's cube solution
         *                   WHITE/UP(2)
         *                        |
         * ORANGE/LEFT(1) - GREEN/FRONT(0) - RED/RIGHT(4) - BLUE/BACK(5)
         *                        |
         *                  YELLOW/DOWN(3)
         */
        public static void PrintSolution(Cube cube)
        {
            var faces = cube.GetFaces();
            Console.WriteLine("********************************************");
            Console.WriteLine("Up face:");
            Console.WriteLine("---------");
            PrintFaceAsMatrix(faces[2]);
            Console.Write(Environment.NewLine);
            Console.WriteLine("Front face:");
            Console.WriteLine("------------");
            PrintFaceAsMatrix(faces[0]);
            Console.Write(Environment.NewLine);
            Console.WriteLine("Left face:");
            Console.WriteLine("------------");
            PrintFaceAsMatrix(faces[1]);
            Console.Write(Environment.NewLine);
            Console.WriteLine("Right face:");
            Console.WriteLine("------------");
            PrintFaceAsMatrix(faces[4]);
            Console.Write(Environment.NewLine);
            Console.WriteLine("Back face:");
            Console.WriteLine("------------");
            PrintFaceAsMatrix(faces[5]);
            Console.Write(Environment.NewLine);
            Console.WriteLine("Down face:");
            Console.WriteLine("------------");
            PrintFaceAsMatrix(faces[3]);
            Console.Write(Environment.NewLine);
        }

        private static void PrintFaceAsMatrix(Colour[,] face)
        {
            int totalRows = face.GetLength(0);
            int totalCols = face.GetLength(1);
            for (int col = 0; col < totalCols; col++)
            {
                for (int row = 0; row < totalRows; row++)
                {
                    Console.Write(string.Format("{0} ", face[row, col]));
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
