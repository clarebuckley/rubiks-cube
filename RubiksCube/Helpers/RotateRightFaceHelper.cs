using RubiksCube.Enums;
using RubiksCube.Interfaces;

namespace RubiksCube.Helpers
{
    public class RotateRightFaceHelper : IRotationHelper
    {

        public void Rotate(RotationType rotationType, Colour[][,] faces)
        {
            if(rotationType == RotationType.Clockwise)
            {
                RotateClockwise(faces);
            } else
            {
                RotateAntiClockwise(faces);
            }

        }

        private void RotateClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //front -> up -> back -> down 
            faces[(int)FaceType.Front][2, 0] = originalFaces[(int)FaceType.Down][2, 0];
            faces[(int)FaceType.Front][2, 1] = originalFaces[(int)FaceType.Down][2, 1];
            faces[(int)FaceType.Front][2, 2] = originalFaces[(int)FaceType.Down][2, 2];

            faces[(int)FaceType.Up][2, 0] = originalFaces[(int)FaceType.Front][2, 0];
            faces[(int)FaceType.Up][2, 1] = originalFaces[(int)FaceType.Front][2, 1];
            faces[(int)FaceType.Up][2, 2] = originalFaces[(int)FaceType.Front][2, 2];

            faces[(int)FaceType.Back][2, 0] = originalFaces[(int)FaceType.Up][2, 0];
            faces[(int)FaceType.Back][2, 1] = originalFaces[(int)FaceType.Up][2, 1];
            faces[(int)FaceType.Back][2, 2] = originalFaces[(int)FaceType.Up][2, 2];

            faces[(int)FaceType.Down][2, 0] = originalFaces[(int)FaceType.Back][2, 0];
            faces[(int)FaceType.Down][2, 1] = originalFaces[(int)FaceType.Back][2, 1];
            faces[(int)FaceType.Down][2, 2] = originalFaces[(int)FaceType.Back][2, 2];
        }

        private void RotateAntiClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //front -> down -> back -> up
            faces[(int)FaceType.Front][2, 0] = originalFaces[(int)FaceType.Up][2, 0];
            faces[(int)FaceType.Front][2, 1] = originalFaces[(int)FaceType.Up][2, 1];
            faces[(int)FaceType.Front][2, 2] = originalFaces[(int)FaceType.Up][2, 2];

            faces[(int)FaceType.Down][2, 0] = originalFaces[(int)FaceType.Front][2, 0];
            faces[(int)FaceType.Down][2, 1] = originalFaces[(int)FaceType.Front][2, 1];
            faces[(int)FaceType.Down][2, 2] = originalFaces[(int)FaceType.Front][2, 2];

            faces[(int)FaceType.Back][2, 0] = originalFaces[(int)FaceType.Down][2, 0];
            faces[(int)FaceType.Back][2, 1] = originalFaces[(int)FaceType.Down][2, 1];
            faces[(int)FaceType.Back][2, 2] = originalFaces[(int)FaceType.Down][2, 2];

            faces[(int)FaceType.Up][2, 0] = originalFaces[(int)FaceType.Back][2, 0];
            faces[(int)FaceType.Up][2, 1] = originalFaces[(int)FaceType.Back][2, 1];
            faces[(int)FaceType.Up][2, 2] = originalFaces[(int)FaceType.Back][2, 2];

        }

    }
}