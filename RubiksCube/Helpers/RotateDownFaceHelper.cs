using RubiksCube.Enums;
using RubiksCube.Interfaces;

namespace RubiksCube.Helpers
{
    public class RotateDownFaceHelper : IRotationHelper
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

            //front -> right -> back -> left
            faces[(int)FaceType.Front][0, 2] = originalFaces[(int)FaceType.Left][0, 2];
            faces[(int)FaceType.Front][1, 2] = originalFaces[(int)FaceType.Left][0, 2];
            faces[(int)FaceType.Front][2, 2] = originalFaces[(int)FaceType.Left][0, 2];

            faces[(int)FaceType.Left][0, 2] = originalFaces[(int)FaceType.Back][0, 2];
            faces[(int)FaceType.Left][1, 2] = originalFaces[(int)FaceType.Back][0, 2];
            faces[(int)FaceType.Left][2, 2] = originalFaces[(int)FaceType.Back][0, 2];

            faces[(int)FaceType.Back][0, 2] = originalFaces[(int)FaceType.Right][0, 2];
            faces[(int)FaceType.Back][1, 2] = originalFaces[(int)FaceType.Right][0, 2];
            faces[(int)FaceType.Back][2, 2] = originalFaces[(int)FaceType.Right][0, 2];

            faces[(int)FaceType.Right][0, 2] = originalFaces[(int)FaceType.Front][0, 2];
            faces[(int)FaceType.Right][1, 2] = originalFaces[(int)FaceType.Front][0, 2];
            faces[(int)FaceType.Right][2, 2] = originalFaces[(int)FaceType.Front][0, 2];
        }

        private void RotateAntiClockwise(Colour[][,] faces)
        {
            Colour[][,] originalFaces = ArrayHelper.DeepCloneFaces(faces);

            //front -> left -> back -> right
            faces[(int)FaceType.Front][0, 2] = originalFaces[(int)FaceType.Right][0, 2];
            faces[(int)FaceType.Front][1, 2] = originalFaces[(int)FaceType.Right][0, 2];
            faces[(int)FaceType.Front][2, 2] = originalFaces[(int)FaceType.Right][0, 2];

            faces[(int)FaceType.Right][0, 2] = originalFaces[(int)FaceType.Back][0, 2];
            faces[(int)FaceType.Right][1, 2] = originalFaces[(int)FaceType.Back][0, 2];
            faces[(int)FaceType.Right][2, 2] = originalFaces[(int)FaceType.Back][0, 2];

            faces[(int)FaceType.Back][0, 2] = originalFaces[(int)FaceType.Left][0, 2];
            faces[(int)FaceType.Back][1, 2] = originalFaces[(int)FaceType.Left][0, 2];
            faces[(int)FaceType.Back][2, 2] = originalFaces[(int)FaceType.Left][0, 2];

            faces[(int)FaceType.Left][0, 2] = originalFaces[(int)FaceType.Front][0, 2];
            faces[(int)FaceType.Left][1, 2] = originalFaces[(int)FaceType.Front][0, 2];
            faces[(int)FaceType.Left][2, 2] = originalFaces[(int)FaceType.Front][0, 2];
        }

    }
}