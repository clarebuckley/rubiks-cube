using RubiksCube.Classes;
using System;
using RubiksCube.Enums;
using RubiksCube.Interfaces;
using RubiksCube.Helpers;

namespace RubiksCube
{
    public class Program
    {
        static void Main(string[] args)
        {
            IRotationHelper rotateFrontFaceHelper = new RotateFrontFaceHelper();
            IRotationHelper rotateRightFaceHelper = new RotateRightFaceHelper();
            IRotationHelper rotateUpFaceHelper = new RotateUpFaceHelper();
            IRotationHelper rotateBackFaceHelper = new RotateBackFaceHelper();
            IRotationHelper rotateLeftFaceHelper = new RotateLeftFaceHelper();
            IRotationHelper rotateDownFaceHelper = new RotateDownFaceHelper();

            Cube cube = new(rotateFrontFaceHelper, 
                            rotateRightFaceHelper, 
                            rotateUpFaceHelper,
                            rotateBackFaceHelper,
                            rotateLeftFaceHelper,
                            rotateDownFaceHelper);

            RotateCubeSequence(cube);

            Console.WriteLine("End configuration:");
            cube.PrintSolution();
        }

        private static void RotateCubeSequence(Cube cube)
        {
            cube.Rotate(FaceType.Front, RotationType.Clockwise);
            cube.Rotate(FaceType.Right, RotationType.Anticlockwise);
            cube.Rotate(FaceType.Up, RotationType.Clockwise);      
            cube.Rotate(FaceType.Back, RotationType.Anticlockwise);
            cube.Rotate(FaceType.Left, RotationType.Clockwise);
            cube.Rotate(FaceType.Down, RotationType.Anticlockwise);
        }
    }

}