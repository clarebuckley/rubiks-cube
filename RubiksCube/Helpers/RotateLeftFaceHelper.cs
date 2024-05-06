using RubiksCube.Enums;
using RubiksCube.Interfaces;

namespace RubiksCube.Helpers
{
    public class RotateLeftFaceHelper : IRotationHelper
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

            //up -> front -> down -> back
            faces[(int)FaceType.Up][0, 0] = originalFaces[(int)FaceType.Back][2, 2];
            faces[(int)FaceType.Up][0, 1] = originalFaces[(int)FaceType.Back][2, 1];
            faces[(int)FaceType.Up][0, 2] = originalFaces[(int)FaceType.Back][2, 0];

            faces[(int)FaceType.Back][2, 0] = originalFaces[(int)FaceType.Down][0, 2];
            faces[(int)FaceType.Back][2, 1] = originalFaces[(int)FaceType.Down][0, 1];
            faces[(int)FaceType.Back][2, 2] = originalFaces[(int)FaceType.Down][0, 0];

            faces[(int)FaceType.Down][0, 0] = originalFaces[(int)FaceType.Front][0, 0];
            faces[(int)FaceType.Down][0, 1] = originalFaces[(int)FaceType.Front][0, 1];
            faces[(int)FaceType.Down][0, 2] = originalFaces[(int)FaceType.Front][0, 2];

            faces[(int)FaceType.Front][0, 0] = originalFaces[(int)FaceType.Up][0, 0];
            faces[(int)FaceType.Front][0, 1] = originalFaces[(int)FaceType.Up][0, 1];
            faces[(int)FaceType.Front][0, 2] = originalFaces[(int)FaceType.Up][0, 2];

            faces[(int)FaceType.Left] = ArrayHelper.RotateArray90Degrees(originalFaces[(int)FaceType.Left], true);

            return faces;
        }

        private static Colour[][,] RotateAntiClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //up -> back -> down -> front
            faces[(int)FaceType.Up][0, 0] = originalFaces[(int)FaceType.Front][0, 0];
            faces[(int)FaceType.Up][0, 1] = originalFaces[(int)FaceType.Front][0, 1];
            faces[(int)FaceType.Up][0, 2] = originalFaces[(int)FaceType.Front][0, 2];

            faces[(int)FaceType.Front][0, 0] = originalFaces[(int)FaceType.Down][0, 0];
            faces[(int)FaceType.Front][0, 1] = originalFaces[(int)FaceType.Down][0, 1];
            faces[(int)FaceType.Front][0, 2] = originalFaces[(int)FaceType.Down][0, 2];

            faces[(int)FaceType.Down][0, 0] = originalFaces[(int)FaceType.Back][2, 0];
            faces[(int)FaceType.Down][0, 1] = originalFaces[(int)FaceType.Back][2, 1];
            faces[(int)FaceType.Down][0, 2] = originalFaces[(int)FaceType.Back][2, 2];

            faces[(int)FaceType.Back][2, 0] = originalFaces[(int)FaceType.Up][0, 0];
            faces[(int)FaceType.Back][2, 1] = originalFaces[(int)FaceType.Up][0, 1];
            faces[(int)FaceType.Back][2, 2] = originalFaces[(int)FaceType.Up][0, 2];

            faces[(int)FaceType.Left] = ArrayHelper.RotateArray90Degrees(originalFaces[(int)FaceType.Left], false);


            return faces;
        }

    }
}