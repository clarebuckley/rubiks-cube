using Newtonsoft.Json;
using RubiksCube.Enums;
namespace RubiksCube.Helpers
{
    public class ArrayHelper
    {
        public static Colour[][,] DeepCloneFaces(Colour[][,] array)
        {
            var serialized = JsonConvert.SerializeObject(array);
            return JsonConvert.DeserializeObject<Colour[][,]>(serialized);
        }

        public static Colour[,] RotateArray90Degrees(Colour[,] array, bool clockwise)
        {
            int width;
            int height;
            Colour[,] result;

            width = array.GetUpperBound(0) + 1;
            height = array.GetUpperBound(1) + 1;
            result = new Colour[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    int newRow;
                    int newCol;
                    if (clockwise)
                    {
                        newRow = col;
                        newCol = height - (row + 1);
                    } else
                    {
                        newRow = width - (col + 1);
                        newCol = row;
                    }

                    result[newCol, newRow] = array[col, row];
                }
            }

            return result;
        }
    }

}