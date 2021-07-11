## Section 3 -- Notes

### Lecture 39

- There is a bug that happens when applying rotations through force, and having rotations being applied by the physics system when colliding with objects of the world. To Fix that, a `rigidbody.freezeRotation = true` is applied within the function that applies the Rotation to the rocket, before applying the rotation, and then `rigidbody.freezeRotation = false` after applying