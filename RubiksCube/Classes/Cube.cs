using RubiksCube.Enums;
using RubiksCube.Helpers;
using RubiksCube.Interfaces;
using System;

namespace RubiksCube.Classes
{
    public class Cube
    {
        private Colour[][,] _faces;
        private readonly IRotationHelper _rotateFrontFaceHelper;
        private readonly IRotationHelper _rotateRightFaceHelper;
        private readonly IRotationHelper _rotateUpFaceHelper;
        private readonly IRotationHelper _rotateBackFaceHelper;
        private readonly IRotationHelper _rotateLeftFaceHelper;
        private readonly IRotationHelper _rotateDownFaceHelper;

        public Cube(IRotationHelper rotateFrontFaceHelper, 
                    IRotationHelper rotateRightFaceHelper,
                    IRotationHelper rotateUpFaceHelper,
                    IRotationHelper rotateBackFaceHelper,
                    IRotationHelper rotateLeftFaceHelper,
                    IRotationHelper rotateDownFacehelper)
        {
            Colour[,] frontFace = {
                { Colour.Green, Colour.Green, Colour.Green },
                { Colour.Green, Colour.Green, Colour.Green },
                { Colour.Green, Colour.Green, Colour.Green },
            };

            Colour[,] leftFace = {
                { Colour.Orange, Colour.Orange, Colour.Orange },
                { Colour.Orange, Colour.Orange, Colour.Orange },
                { Colour.Orange, Colour.Orange, Colour.Orange },
            };

            Colour[,] upFace = {
                { Colour.White, Colour.White, Colour.White },
                { Colour.White, Colour.White, Colour.White },
                { Colour.White, Colour.White, Colour.White },
            };

            Colour[,] downFace = {
                { Colour.Yellow, Colour.Yellow, Colour.Yellow },
                { Colour.Yellow, Colour.Yellow, Colour.Yellow },
                { Colour.Yellow, Colour.Yellow, Colour.Yellow },
            };

            Colour[,] rightFace = {
                { Colour.Red, Colour.Red, Colour.Red },
                { Colour.Red, Colour.Red, Colour.Red },
                { Colour.Red, Colour.Red, Colour.Red },
            };

            Colour[,] backFace = {
                { Colour.Blue, Colour.Blue, Colour.Blue },
                { Colour.Blue, Colour.Blue, Colour.Blue },
                { Colour.Blue, Colour.Blue, Colour.Blue },
            };

            Colour[][,] faces = { frontFace, leftFace, upFace, downFace, rightFace, backFace };

            _faces = faces;
            _rotateFrontFaceHelper = rotateFrontFaceHelper;
            _rotateRightFaceHelper = rotateRightFaceHelper;
            _rotateUpFaceHelper = rotateUpFaceHelper;
            _rotateBackFaceHelper = rotateBackFaceHelper;
            _rotateLeftFaceHelper = rotateLeftFaceHelper;
            _rotateDownFaceHelper = rotateDownFacehelper;
        }

        public Colour[][,] GetFaces()
        {
            return _faces;
        }

        public void SetFaces(Colour[][,] faces)
        {
            _faces = faces;
        }

        public void PrintSolution()
        {
            PrintHelper.PrintSolution(this);
        }

        public void Rotate(FaceType faceType, RotationType rotationType)
        {
            switch (faceType)
            {
                case FaceType.Front:
                    SetFaces(_rotateFrontFaceHelper.Rotate(rotationType, _faces));
                    break;
                case FaceType.Right:
                    SetFaces(_rotateRightFaceHelper.Rotate(rotationType, _faces));
                    break;
                case FaceType.Up:
                    SetFaces(_rotateUpFaceHelper.Rotate(rotationType, _faces));
                    break;
                case FaceType.Back:
                    SetFaces(_rotateBackFaceHelper.Rotate(rotationType, _faces));
                    break;
                case FaceType.Left:
                    SetFaces(_rotateLeftFaceHelper.Rotate(rotationType, _faces));
                    break;
                case FaceType.Down:
                    SetFaces(_rotateDownFaceHelper.Rotate(rotationType, _faces));
                    break;
                default: throw new ArgumentException($"Error: Invalid face type: {rotationType}");
            }
        }

    }
}