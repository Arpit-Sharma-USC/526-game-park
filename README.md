# dashball

The game is an ‘Endless Runner’ in 3D. It targets a handheld android device. The objective of the game is to go as far as possible on a strip of varying width, avoiding the obstacles and pits at the same time. The mechanics are very fundamental; the user object can be moved to the left, right or a jump-motion by swiping on the screen. There are two variants of the pits, the bad pit which results in a ‘Game Over’ state and the good pit which emulates a warp-portal and helps the player avoid obstacles in the way, see figure 1.1. 
<br><br>
Please refer to [https://docs.google.com/document/d/16wJz71jGK3Lo1ic5JYCKR0tqpDvgvODbPwH06fmS0cw/edit](https://docs.google.com/document/d/16wJz71jGK3Lo1ic5JYCKR0tqpDvgvODbPwH06fmS0cw/edit) for game design details. 

## Notes

### Importing this project to Unity3D
Open up your terminal, and clone the repository by typing<br>
`$ git clone https://github.com/subwaymatch/dashball`<br>
<br>
Open up Unity, and click on "Open" when Projects window pops up. 

### File organizations
- `Assets/Scripts` All C# scripts for the game
- `Assets/Scenes` Scenes of the game - there will be 3~4 different scenes to handle teleportation between portals
- `Assets/Prefabs` These store "prefabs" - templates for floor, reward, obstacle, and any other game objects dynamically created during the game
- `Assets/Materials` Materials for game objects

