# Rubiks cube repesentation project
This is a C# representation of a Rubik's cube, which prints the state of each face of the cube after the following rotations:
* Front face clockwise 90 degrees
* Right face anti-clockwise 90 degrees
* Up face clockwise 90 degrees
* Back face anti-clockwise 90 degrees
* Left face clockwise 90 degrees
* Down face anti-clockwise 90 degrees

The faces are printed in the flat view of the rubik's cube, and are initialised as shown below:

                            WHITE/UP
                                |
          ORANGE/LEFT - GREEN/FRONT - RED/RIGHT - BLUE/BACK
                                 |
                           YELLOW/DOWN
         
The sequence above can be set up and compared against using the 'flat view' here: https://rubiks-cube-solver.com/

## Running the solution
To run the solution, please run 'Program.cs' using Visual Studio.
This requires no inputs.

## Future considerations
Given this project was created at an MVP level, there are multiple improvements that could be made in future iterations:
* Added unit test coverage (only manually tested currently)
* Refactoring the use of 'Colour' enum - this could allow matrix rotations to be applied more generically, and remove the need for a manual 'deepClone'
* Refactor the rotation methods for each face to be more generic/re-usable (avoid repetition of logic)
* Added support for rotations of more than 90 degrees
* Added ability for user input to determine rotations of each face, with extra error/exception handling to give user-friendly feedback

### Test scenarios
Due to time constraints, unit testing has not yet been added to the project. Below is a high level summary of unit testing that should be completed in the future:
* ArrayHelper.cs
  * assert matrix is in correct configuration for rotations clockwise and anticlockwise
  * assert that DeepClone results in expected Colour[][,] values
 * PrintHelper.cs
   * assert that PrintFaceAsMatrix prints values in the correct orientation
 * Rotate[Back/Down/Front/Left/Right/Up]FaceHelper.cs
   * Assert center squares never move
   * Assert that there are 9 squares of each colour after any rotation
   * Assert clockwise rotation results in expected colour configuration
     * For faces where colours have moved between faces
     * For the rotated face which requires a rotation of 90 degrees
   * Assert anticlockwise rotation results in expected colour configuration
