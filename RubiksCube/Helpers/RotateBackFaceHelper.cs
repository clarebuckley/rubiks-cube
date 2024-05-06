using RubiksCube.Enums;
using RubiksCube.Interfaces;

namespace RubiksCube.Helpers
{
    public class RotateBackFaceHelper : IRotationHelper
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

            //up -> left -> down -> right
            faces[(int)FaceType.Up][0, 0] = originalFaces[(int)FaceType.Right][2, 0];
            faces[(int)FaceType.Up][1, 0] = originalFaces[(int)FaceType.Right][2, 1];
            faces[(int)FaceType.Up][2, 0] = originalFaces[(int)FaceType.Right][2, 2];

            faces[(int)FaceType.Right][2, 0] = originalFaces[(int)FaceType.Down][2, 0];
            faces[(int)FaceType.Right][2, 1] = originalFaces[(int)FaceType.Down][2, 1];
            faces[(int)FaceType.Right][2, 2] = originalFaces[(int)FaceType.Down][2, 2];

            faces[(int)FaceType.Down][2, 0] = originalFaces[(int)FaceType.Left][0, 0];
            faces[(int)FaceType.Down][2, 1] = originalFaces[(int)FaceType.Left][0, 1];
            faces[(int)FaceType.Down][2, 2] = originalFaces[(int)FaceType.Left][0, 2];

            faces[(int)FaceType.Left][0, 0] = originalFaces[(int)FaceType.Up][0, 0];
            faces[(int)FaceType.Left][0, 1] = originalFaces[(int)FaceType.Up][1, 0];
            faces[(int)FaceType.Left][0, 2] = originalFaces[(int)FaceType.Up][2, 0];

            faces[(int)FaceType.Back] = ArrayHelper.RotateArray90Degrees(originalFaces[(int)FaceType.Back], true);

            return faces;
        }

        private static Colour[][,] RotateAntiClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //up -> right -> down -> left
            faces[(int)FaceType.Up][0, 0] = originalFaces[(int)FaceType.Left][0, 2];
            faces[(int)FaceType.Up][1, 0] = originalFaces[(int)FaceType.Left][0, 1];
            faces[(int)FaceType.Up][2, 0] = originalFaces[(int)FaceType.Left][0, 0];

            faces[(int)FaceType.Left][0, 0] = originalFaces[(int)FaceType.Down][0, 2];
            faces[(int)FaceType.Left][0, 1] = originalFaces[(int)FaceType.Down][1, 1];
            faces[(int)FaceType.Left][0, 2] = originalFaces[(int)FaceType.Down][2, 0];

            faces[(int)FaceType.Down][0, 2] = originalFaces[(int)FaceType.Right][2, 2];
            faces[(int)FaceType.Down][1, 2] = originalFaces[(int)FaceType.Right][2, 1];
            faces[(int)FaceType.Down][2, 2] = originalFaces[(int)FaceType.Right][2, 0];

            faces[(int)FaceType.Right][2, 0] = originalFaces[(int)FaceType.Up][0, 0];
            faces[(int)FaceType.Right][2, 1] = originalFaces[(int)FaceType.Up][1, 0];
            faces[(int)FaceType.Right][2, 2] = originalFaces[(int)FaceType.Up][2, 0];

            faces[(int)FaceType.Back] = ArrayHelper.RotateArray90Degrees(originalFaces[(int)FaceType.Back], false);


            return faces;
        }

    }
}