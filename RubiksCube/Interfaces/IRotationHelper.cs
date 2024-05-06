using RubiksCube.Enums;

namespace RubiksCube.Interfaces
{
    public interface IRotationHelper
    {
        public Colour[][,] Rotate(RotationType rotationType, Colour[][,] faces);
    }
}
