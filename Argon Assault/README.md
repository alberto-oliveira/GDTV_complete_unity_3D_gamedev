## Section 4: Argon Assault Notes

### Lecture 64 - Game Design: Argon Assault

#### Game Design

**Player Experience:** Chaos
**Core Mechanic:** Dodge and Shoot
**Core game loop:** Get as far as possible without dying, in order to get the highest score possible. Start from beginning when die.

#### Features

**Camera Rail:** path through the levl that the camera follows
**Player Movement:** horizontal and vertical movement
**Shooting:** Player shoot bullets which do damage to opponent
**Health:** enemies have health that depletes when shot
**Enemy Paths:** enemies should travel on paths and be hand placed by the designer
**Score:** points are given for killing enemies
**Game Loop:** upon dying, player restarts the level

### Lecture 65 - How To Add Terrain

- Terrain is a 3D Object, and can be set as such
- Width and Length can be set on Settings Tab
- On Paint terrain, you can draw terrain features. Opacity of the brush is how fast the terrain rises or lowers
- `Left click` to rise terrain, `shift+left click` to lower
- To make valleys: right under the the Paint Terrain button, there is a space drop mene. Set the *Height*  value to fix a maximum height (any painted terrain will be limited to that height). You can then click *Flatten All*  to set all the terrain to the height specified. Then it is possible to draw valleys.
- Set the terrain to `y = -H`, `H` being the height set at the previous step, so objects don't need to have their `y` adjusted
- Holding down `right click` to look around, you can use the WASD keys to move like an FPS. Mouse scroll adjust speed, and `shift` increases speed. You can change the maximum speed at the camera button close to the *Gizmos* button, and also disable camera acceleration

### Lecture 65 - Unity Terrain Tools