using Newtonsoft.Json;
using RubiksCube.Classes;
using RubiksCube.Enums;
using System;

namespace RubiksCube.Helpers
{
    public class ArrayHelper
    {
        public static Colour[][,] DeepCloneFaces(Colour[][,] array)
        {
            var serialized = JsonConvert.SerializeObject(array);
            return JsonConvert.DeserializeObject<Colour[][,]>(serialized);
        }
    }
}
