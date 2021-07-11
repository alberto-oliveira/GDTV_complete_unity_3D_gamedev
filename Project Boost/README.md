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