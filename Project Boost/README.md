## Section 3 Notes

### Lecture 39 - RigidBody Constraints

- There is a bug that happens when applying rotations through force, and having rotations being applied by the physics system when colliding with objects of the world. To Fix that, a `rigidbody.freezeRotation = true` is applied within the function that applies the Rotation to the rocket, before applying the rotation, and then `rigidbody.freezeRotation = false` after applying

### Lecture 41 - Unity Audio Introduction

- Needs three things for audio:
    1. `Audio File`: the sounds that get played
    2. `Audio Source`: what playes the `Audio File`
    3. `Audio Listener`: what listens to the `Audio Source`

- Common Issues with Audio:
    - **Mute Audio** is checked on  play windows, uncheck it
    - Project Settings > Audio > System Sample Rate is set to 0, and thus audio does not play