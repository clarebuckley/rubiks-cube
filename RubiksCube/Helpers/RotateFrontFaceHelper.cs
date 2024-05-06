using Newtonsoft.Json;
using RubiksCube.Enums;
using RubiksCube.Interfaces;
using System;

using System.Linq;

namespace RubiksCube.Helpers
{
    public class RotateFrontFaceHelper : IRotationHelper
    {

        public Colour[][,] Rotate(RotationType rotationType, Colour[][,] faces)
        {
            if (rotationType == RotationType.Clockwise)
            {
                return RotateClockwise(faces);
            }
            else
            {
                return RotateAntiClockwise(faces);
            }

        }

        private static Colour[][,] RotateClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);
            //up -> right -> down -> left
            faces[(int)FaceType.Up][0, 2] = originalFaces[(int)FaceType.Left][2, 0];
            faces[(int)FaceType.Up][1, 2] = originalFaces[(int)FaceType.Left][2, 1];
            faces[(int)FaceType.Up][2, 2] = originalFaces[(int)FaceType.Left][2, 2];

            faces[(int)FaceType.Right][0, 0] = originalFaces[(int)FaceType.Up][0, 2];
            faces[(int)FaceType.Right][0, 1] = originalFaces[(int)FaceType.Up][1, 2];
            faces[(int)FaceType.Right][0, 2] = originalFaces[(int)FaceType.Up][2, 2];

            faces[(int)FaceType.Down][0, 0] = originalFaces[(int)FaceType.Right][0, 0];
            faces[(int)FaceType.Down][1, 0] = originalFaces[(int)FaceType.Right][0, 1];
            faces[(int)FaceType.Down][2, 0] = originalFaces[(int)FaceType.Right][0, 2];

            faces[(int)FaceType.Left][2, 0] = originalFaces[(int)FaceType.Down][0, 0];
            faces[(int)FaceType.Left][2, 1] = originalFaces[(int)FaceType.Down][1, 0];
            faces[(int)FaceType.Left][2, 2] = originalFaces[(int)FaceType.Down][2, 2];

            faces[(int)FaceType.Front] = ArrayHelper.RotateArray90Degrees(originalFaces[(int)FaceType.Front], true);

            return faces;
        }

        private static Colour[][,] RotateAntiClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);
            
            //left -> down -> right -> up
            faces[(int)FaceType.Up][0, 2] = originalFaces[(int)FaceType.Right][0, 0];
            faces[(int)FaceType.Up][1, 2] = originalFaces[(int)FaceType.Right][0, 1];
            faces[(int)FaceType.Up][2, 2] = originalFaces[(int)FaceType.Right][0, 2];

            faces[(int)FaceType.Right][0, 0] = originalFaces[(int)FaceType.Down][0, 0];
            faces[(int)FaceType.Right][0, 1] = originalFaces[(int)FaceType.Down][1, 0];
            faces[(int)FaceType.Right][0, 2] = originalFaces[(int)FaceType.Down][2, 0];

            faces[(int)FaceType.Down][0, 0] = originalFaces[(int)FaceType.Left][2, 0];
            faces[(int)FaceType.Down][1, 0] = originalFaces[(int)FaceType.Left][2, 1];
            faces[(int)FaceType.Down][2, 0] = originalFaces[(int)FaceType.Left][2, 2];

            faces[(int)FaceType.Left][2, 0] = originalFaces[(int)FaceType.Up][0, 2];
            faces[(int)FaceType.Left][2, 1] = originalFaces[(int)FaceType.Up][1, 2];
            faces[(int)FaceType.Left][2, 2] = originalFaces[(int)FaceType.Up][2, 2];
            
            faces[(int)FaceType.Front] = ArrayHelper.RotateArray90Degrees(originalFaces[(int)FaceType.Front], false);

            return faces;
        }
    }
}