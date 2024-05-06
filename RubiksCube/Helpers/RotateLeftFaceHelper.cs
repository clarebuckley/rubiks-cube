using RubiksCube.Enums;
using RubiksCube.Interfaces;

namespace RubiksCube.Helpers
{
    public class RotateLeftFaceHelper : IRotationHelper
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

            //up -> front -> down -> back
            faces[(int)FaceType.Up][0, 0] = originalFaces[(int)FaceType.Back][0, 0];
            faces[(int)FaceType.Up][0, 1] = originalFaces[(int)FaceType.Back][0, 1];
            faces[(int)FaceType.Up][0, 2] = originalFaces[(int)FaceType.Back][0, 2];

            faces[(int)FaceType.Back][0, 0] = originalFaces[(int)FaceType.Down][0, 0];
            faces[(int)FaceType.Back][0, 1] = originalFaces[(int)FaceType.Down][0, 1];
            faces[(int)FaceType.Back][0, 2] = originalFaces[(int)FaceType.Down][0, 2];

            faces[(int)FaceType.Down][0, 0] = originalFaces[(int)FaceType.Front][0, 0];
            faces[(int)FaceType.Down][0, 1] = originalFaces[(int)FaceType.Front][0, 1];
            faces[(int)FaceType.Down][0, 2] = originalFaces[(int)FaceType.Front][0, 2];

            faces[(int)FaceType.Front][0, 0] = originalFaces[(int)FaceType.Up][0, 0];
            faces[(int)FaceType.Front][0, 1] = originalFaces[(int)FaceType.Up][0, 1];
            faces[(int)FaceType.Front][0, 2] = originalFaces[(int)FaceType.Up][0, 2];
        }

        private void RotateAntiClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //up -> back -> down -> front
            faces[(int)FaceType.Up][0, 0] = originalFaces[(int)FaceType.Front][0, 0];
            faces[(int)FaceType.Up][0, 1] = originalFaces[(int)FaceType.Front][0, 1];
            faces[(int)FaceType.Up][0, 2] = originalFaces[(int)FaceType.Front][0, 2];

            faces[(int)FaceType.Front][0, 0] = originalFaces[(int)FaceType.Down][0, 0];
            faces[(int)FaceType.Front][0, 1] = originalFaces[(int)FaceType.Down][0, 1];
            faces[(int)FaceType.Front][0, 2] = originalFaces[(int)FaceType.Down][0, 2];

            faces[(int)FaceType.Down][0, 0] = originalFaces[(int)FaceType.Back][0, 0];
            faces[(int)FaceType.Down][0, 1] = originalFaces[(int)FaceType.Back][0, 1];
            faces[(int)FaceType.Down][0, 2] = originalFaces[(int)FaceType.Back][0, 2];

            faces[(int)FaceType.Back][0, 0] = originalFaces[(int)FaceType.Up][0, 0];
            faces[(int)FaceType.Back][0, 1] = originalFaces[(int)FaceType.Up][0, 1];
            faces[(int)FaceType.Back][0, 2] = originalFaces[(int)FaceType.Up][0, 2];
        }

    }
}