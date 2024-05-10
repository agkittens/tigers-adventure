# tigers-adventure
## Overview

Welcome to Tiger's Adventure Game! This game is built around solving 3 short riddles on various islands. The application was developed using C# within the Unity environment. The game features character movement, camera control, room transitions, and continuous background music. Additionally, there are interactive elements such as pressing buttons, rotating wheels, and moving boxes to solve puzzles. 

## Features

- **Character Movement:** Players can control the character's movement using the W, S, A, D keys, as well as arrow keys.
- **Camera Control:** The camera follows the character's movement, adjusting its position and rotation accordingly.
- **Room Transitions:** Moving between different areas of the game is seamless, enhancing the player's experience.
- **Interactive Elements:** Players can interact with various objects in the game world, such as buttons, wheels, and boxes.
- **Saving and Loading:** The game includes functionality to save and load progress, allowing players to continue from where they left off.
- **Main Menu:** The main menu offers options to start a new game, continue from a saved point, or exit the game.
- **Graphics and Models:** All graphics and 3D models, including scenery and characters, are custom-made for the game.
- **Animations:** The character features animations for idle and walking states, enhancing immersion.
- **Music:** Continuous music accompanies players throughout the gameplay, creating atmosphere.

## Instructions

1. **Main Menu:** Upon starting the game, players are greeted with the main menu where they can choose to start a new game, continue from a saved point, or exit.
![menu](https://github.com/agkittens/tigers-adventure/blob/main/examples/1.png?raw=true)
2. **Character Movement:** Use the W, S, A, D keys or arrow keys to move the character. The camera follows the character's movements.
![start](https://github.com/agkittens/tigers-adventure/blob/main/examples/2.png?raw=true)
3. **Island Exploration:** Navigate between islands using bridges. If the character falls off an island, they are teleported back to the main island.
4. **Puzzles:** There are 3 puzzles scattered across the islands and the temple. Solve each puzzle to collect trophies.
   - **Button Puzzle:** Press 3 buttons within 8 seconds on the left island to solve this puzzle.
   - **Wheel Puzzle:** Rotate wheels to match the color sequence (yellow, green, blue) on the right island.
   - **Box Puzzle:** Move boxes to uncover a hidden object in the temple.
![riddle1](https://github.com/agkittens/tigers-adventure/blob/main/examples/3.png?raw=true)
![riddle2](https://github.com/agkittens/tigers-adventure/blob/main/examples/4.png?raw=true)
![riddle3](https://github.com/agkittens/tigers-adventure/blob/main/examples/5.png?raw=true)
5. **Game Completion:** The game ends once all 3 trophies are collected.
6. **Saving Progress:** Progress is automatically saved, allowing players to continue their adventure later.
7. **Music:** Enjoy continuous background music throughout the gameplay.

## Folder Structure

- `/Assets/Scripts`: Contains all C# scripts for game mechanics.
- `/Assets/Interactive`: Contains scripts and assets for interactive elements.
- `/Assets/Graphics`: Includes graphics and 3D models for characters, scenery, and objects.

## Getting Started

To play the game, simply open the Unity project and run the game from the main menu scene.
