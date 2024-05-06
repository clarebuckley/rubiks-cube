using RubiksCube.Enums;
using RubiksCube.Interfaces;

namespace RubiksCube.Helpers
{
    public class RotateBackFaceHelper : IRotationHelper
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

            //up -> left -> down -> right
            faces[(int)FaceType.Up][0, 0] = originalFaces[(int)FaceType.Right][0, 0];
            faces[(int)FaceType.Up][1, 0] = originalFaces[(int)FaceType.Right][1, 0];
            faces[(int)FaceType.Up][2, 0] = originalFaces[(int)FaceType.Right][2, 0];

            faces[(int)FaceType.Right][0, 0] = originalFaces[(int)FaceType.Down][0, 0];
            faces[(int)FaceType.Right][1, 0] = originalFaces[(int)FaceType.Down][1, 0];
            faces[(int)FaceType.Right][2, 0] = originalFaces[(int)FaceType.Down][2, 0];

            faces[(int)FaceType.Down][0, 0] = originalFaces[(int)FaceType.Left][0, 0];
            faces[(int)FaceType.Down][1, 0] = originalFaces[(int)FaceType.Left][1, 0];
            faces[(int)FaceType.Down][2, 0] = originalFaces[(int)FaceType.Left][2, 0];

            faces[(int)FaceType.Left][0, 0] = originalFaces[(int)FaceType.Up][0, 0];
            faces[(int)FaceType.Left][1, 0] = originalFaces[(int)FaceType.Up][1, 0];
            faces[(int)FaceType.Left][2, 0] = originalFaces[(int)FaceType.Up][2, 0];
        }

        private void RotateAntiClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //up -> right -> down -> left
            faces[(int)FaceType.Up][0, 0] = originalFaces[(int)FaceType.Left][0, 0];
            faces[(int)FaceType.Up][1, 0] = originalFaces[(int)FaceType.Left][1, 0];
            faces[(int)FaceType.Up][2, 0] = originalFaces[(int)FaceType.Left][2, 0];

            faces[(int)FaceType.Left][0, 0] = originalFaces[(int)FaceType.Down][0, 0];
            faces[(int)FaceType.Left][1, 0] = originalFaces[(int)FaceType.Down][1, 0];
            faces[(int)FaceType.Left][2, 0] = originalFaces[(int)FaceType.Down][2, 0];

            faces[(int)FaceType.Down][0, 0] = originalFaces[(int)FaceType.Right][0, 0];
            faces[(int)FaceType.Down][1, 0] = originalFaces[(int)FaceType.Right][1, 0];
            faces[(int)FaceType.Down][2, 0] = originalFaces[(int)FaceType.Right][2, 0];

            faces[(int)FaceType.Right][0, 0] = originalFaces[(int)FaceType.Up][0, 0];
            faces[(int)FaceType.Right][1, 0] = originalFaces[(int)FaceType.Up][1, 0];
            faces[(int)FaceType.Right][2, 0] = originalFaces[(int)FaceType.Up][2, 0];
        }

    }
}