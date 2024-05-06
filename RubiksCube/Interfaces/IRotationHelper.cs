using RubiksCube.Enums;

namespace RubiksCube.Interfaces
{
    public interface IRotationHelper
    {
        public void Rotate(RotationType rotationType, Colour[][,] faces);
    }
}
