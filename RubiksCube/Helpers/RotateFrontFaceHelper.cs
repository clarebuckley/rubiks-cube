using Newtonsoft.Json;
using RubiksCube.Enums;
using RubiksCube.Interfaces;
using System;
using System.Linq;

namespace RubiksCube.Helpers
{
    public class RotateFrontFaceHelper : IRotationHelper
    {

        public void Rotate(RotationType rotationType, Colour[][,] faces)
        {
            if (rotationType == RotationType.Clockwise)
            {
                RotateClockwise(faces);
            }
            else
            {
                RotateAntiClockwise(faces);
            }

        }

        private void RotateClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //up -> right -> down -> left
            faces[(int)FaceType.Up][2, 0] = originalFaces[(int)FaceType.Left][2, 0];
            faces[(int)FaceType.Up][2, 1] = originalFaces[(int)FaceType.Left][2, 1];
            faces[(int)FaceType.Up][2, 2] = originalFaces[(int)FaceType.Left][2, 2];

            faces[(int)FaceType.Right][2, 0] = originalFaces[(int)FaceType.Up][2, 0];
            faces[(int)FaceType.Right][2, 1] = originalFaces[(int)FaceType.Up][2, 1];
            faces[(int)FaceType.Right][2, 2] = originalFaces[(int)FaceType.Up][2, 2];

            faces[(int)FaceType.Down][2, 2] = originalFaces[(int)FaceType.Right][2, 0];
            faces[(int)FaceType.Down][2, 1] = originalFaces[(int)FaceType.Right][2, 1];
            faces[(int)FaceType.Down][2, 2] = originalFaces[(int)FaceType.Right][2, 2];

            faces[(int)FaceType.Left][2, 0] = originalFaces[(int)FaceType.Down][2, 0];
            faces[(int)FaceType.Left][2, 1] = originalFaces[(int)FaceType.Down][2, 1];
            faces[(int)FaceType.Left][2, 2] = originalFaces[(int)FaceType.Down][2, 2];
        }

        private void RotateAntiClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //left -> down -> right -> up
            faces[(int)FaceType.Up][2, 0] = originalFaces[(int)FaceType.Right][2, 0];
            faces[(int)FaceType.Up][2, 1] = originalFaces[(int)FaceType.Right][2, 1];
            faces[(int)FaceType.Up][2, 2] = originalFaces[(int)FaceType.Right][2, 2];

            faces[(int)FaceType.Right][2, 0] = originalFaces[(int)FaceType.Down][2, 0];
            faces[(int)FaceType.Right][2, 1] = originalFaces[(int)FaceType.Down][2, 1];
            faces[(int)FaceType.Right][2, 2] = originalFaces[(int)FaceType.Down][2, 2];

            faces[(int)FaceType.Down][2, 0] = originalFaces[(int)FaceType.Left][2, 0];
            faces[(int)FaceType.Down][2, 1] = originalFaces[(int)FaceType.Left][2, 1];
            faces[(int)FaceType.Down][2, 2] = originalFaces[(int)FaceType.Left][2, 2];

            faces[(int)FaceType.Left][2, 0] = originalFaces[(int)FaceType.Up][2, 0];
            faces[(int)FaceType.Left][2, 1] = originalFaces[(int)FaceType.Up][2, 1];
            faces[(int)FaceType.Left][2, 2] = originalFaces[(int)FaceType.Up][2, 2];
        }
    }
}