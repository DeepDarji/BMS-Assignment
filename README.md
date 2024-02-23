# Crimson Tactics - Programming Assignment
<video width="640" height="480" controls>
  <source src="/gameplay.mp4" type="video/mp4">
</video>


## Game Brief

**Crimson Tactics** is a 3D Tactics Game with isometric battlefield maps, inspired by games like Tactics Ogre: Let us Cling Together.

## Assignment 1 – Grid Block Generation

Generate a 10x10 grid of Unity Cubes. Each cube should be a GameObject with attached script containing tile information. Implement ray casting from the mouse to display unit position on hovered tile via UI element.

## Assignment 2 – Obstacles

Create a Unity Tool for obstacle generation on the grid. The tool should feature toggleable buttons for each grid tile, blocking those with toggled-on buttons. Obstacle data should be stored in a Scriptable Object, with an Obstacle Manager script reading it to generate red spheres representing obstacles on the grid.

## Assignment 3 – Pathfinding

Generate a player unit on the grid and implement movement to selected tiles using grid-based pathfinding algorithm. Movement should avoid obstacles from Assignment 2, with visual feedback of movement and disabled input during unit movement.

## Assignment 4 – Enemy AI

Implement an enemy unit with objective to approach the player unit. Enemy should use same grid-based pathfinding algorithm or Unity Pathfinding if not attempted in Assignment 3. It should move to one of four adjacent tiles next to the player's tile and stay idle until player unit moves. Implement using proper OOP concepts with 'Enemy AI' script inheriting from 'AI' interface.
