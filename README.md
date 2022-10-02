# Toy Robot Simulation Game

## Instruction
- Clone the solution
- Build project
- The game starts from main method in "Program.cs" file
- There are **Two Modes** the project runs
- **File Input Mode** - Provide "commands.txt" path in command line

    ```>ToyRobotSimulation.exe C:\commands.txt ```
    
    A sample "commands.txt" is in git
- **User Interactive Mode** - In the absense of valid file name in command line, the project runs in user interactive mode i.e. user enters command
    ```
    Welcome to Toy Robot Game
    Choose one of the following Commands...
    PLACE X,Y,F (F=>NORTH,SOUTH,EAST,WEST)
    MOVE
    LEFT
    RIGHT
    REPORT
    EXIT
    ```

- The unit tests are in the project "ToyRobotSimulation.Test"