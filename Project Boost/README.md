## Section 3 Notes

### Lecture 39 - RigidBody Constraints

- There is a bug that happens when applying rotations through force, and having rotations being applied by the physics system when colliding with objects of the world. To Fix that, a `rigidbody.freezeRotation = true` is applied within the function that applies the Rotation to the rocket, before applying the rotation, and then `rigidbody.freezeRotation = false` after applying

### Lecture 41 - Unity Audio Introduction

- Needs three things for audio:
    1. `Audio File`: the sounds that get played
    2. `Audio Source`: what playes the `Audio File`
    3. `Audio Listener`: what listens to the `Audio Source`

- Audacity for creating audio

- Common Issues with Audio:
    - **Mute Audio** is checked on  play windows, uncheck it
    - Project Settings > Audio > System Sample Rate is set to 0, and thus audio does not play

### Lecture 42 - Play AudioSource SFX

- For continuous SFX that play every frame a condition is true, always check if `AudioSource.isPlaying` before, to avoid overlapping plays

### Lecture 43 - Respawn Using `SceneManager`

- `SceneManager` is in `UnityEngine.SceneManagement` namespace
- You can get index of current scene using `SceneManager.GetActiveScene().buildIndex`
- When loading a scene, illumination may appear broken. That is because in my Unity configuratio, lighting settings are not being created for the scene automatically. So I need to create a lighting setting, and use `auto generate` to keep the lighting as is.

### Lecture 45 - Load Next Level

- Scenes can be duplicated with Ctrl+D, and then changed
- Make sure **overrides are applied to prefabs!**

### Lecture 46 - Using Invoke

- Invoke is used to call a method after a delay; not so good because of string references
- You can get a reference to a script using `GetComponent`, and then disable it, if you want
to disable a certain functionality in some scenarios

### Lecture 47 - Multiple Audio Clips

- You can use `PlayOneShot` to play multiple different audio clips; use `[SerializeField]` to assign audio clips in the editor
- Stop the audio source before playing a new clip

### Lecture 48 - Bool Variable for State

- When scene is loaded, state of class is reset, including variables defined for the class;

### Lecture 49 - Make Rocket Look Spiffy

- You can modify the prefab by double clicking on folder or clicking on the `>` in the Hierarchy
- The childre's position and rotation is relative to the parent's
- For prefabs with children, it is preferable have it without a meshrenderer, and its scale set to `(1, 1, 1)`. That because the `transform` of the parent is applied to the children, and thus scales different than `(1, 1, 1)` can led to several issues, for instances with rotation. In those cases, usually the children will make up the visuals of the prefab, while the parent houses stuff like scripts and audio source
- Beware the pivoting center of the parent object for rotations
- Remove the individual colliders of the children, and use the parent's only

### Lecture 50 - How To Trigger Particles

- There is a Unity GameObject for particles, that can be customized
- To trigger particles depending on the position of a certain GameObject, a few steps need to be followed
    - Add the `ParticleSystem` attributes to the script in the object that will trigger it. For instance, since the crash and success particles are effects of collisions (with objects or the finish pad), they will be part of the `CollisionHandler` script of the object; Make both attributes serializable
    - Add the `ParticleSystem` prefabs as children of the rocket. This is important to guarantee that they will always spawn relative to the transform of the rocket, and thus can be spawn on top of it.
    - On the two `ParticleSystem`serializable fields of the `CollisionHandler` script, drag corresponding **rocket children prefab** `ParticleSystems`. This part is very important! Drag the children, and not the original prefabs, since only the children will be anchored to the Rocket GameObject

### Lecture 51 - Particles for Rocket Booster

- Like with the audio, check if `ParticleSystem.isPlaying` before playing it, to avoid continuously starting it

### Lecture 52 - Refactor with Extract Method
- Cool tricks for VSCode:
    - Select code block then `ctrl + .` to extract that block to a new method/function
    - F2 to rename symbol

### Lecture 53 - Add Cheat/Debug Keys

### Lecture 54 - Make Environment from Blocks

- Changing the Skybox:
    - Open the Lighting Tab > Environment
    - Create a material for the skybox
    - Drag the material in the Skybox field of Environment tab
    - Change the material shader to Skybox>Procedural, change settings to taste
- To make it totally black
    - Go to main camera
    - Change the background to black
    - Change the Clear Flags to `Solid Color`

### Lecture 55 - How to Add Lights from Unity

    - He talks about types of light and emissive materials

### Lecture 56 - Move Object with Code
    
    - You can add `[Range(X, Y)]` in front of `[SerializeField]` to add a range slider for the variable

### Lecture 57 - Mathf.Sin() for Oscillation

    - Oscillator uses the sine function to oscillate the object with time

### Lecture 58 - Protect against NaN error

    - Mathf.Epsilon to compare very small floats

### Lecture 59 - Designing Level Moments

### Lecture 60 - Quit Application

    - With `Application.Quit()`