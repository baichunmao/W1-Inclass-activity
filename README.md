# in-class-activities
## Devlogs
### W1
The cat cannot move.

### W2
1. RGB color values in Unity range from 0.0 to 1.0, which are decimal numbers. A float can store decimal values. Int only holds whole numbers and cannot represent fractions like 0.3 or 0.7. Bool can only be true or false (only two values, useless for color intensity).String stores text, not numbers for math calculations. So we use float for r, g, b to smoothly adjust color brightness.
2. Bounce counts how many times the ball collides. Bounces are whole numbers. Int stores whole counting numbers perfectly.Float allows decimals, but you cannot have half a bounce.Bool only has true/false, cannot count multiple bounces.String stores words and cannot do addition to increment the count.
3. The error showed that we cannot modify the color value directly from spriteRenderer. When we read spriteRenderer, it returns a copy of the color data, not the original value. Changing the copy will not change the actual color on the sprite.That’s why we first copy r, g, b into separate local float variables, modify those variables, then assign the full color back with new Color(r,g,b).

### W3
Activity 1: 
1. parameter: int friendship level; bool Knows secret); Output is a string
2. Parameter: float sanity; Output: void
3. Parameter: float timeHit; Output: bool
Activity 2:
We use a cookie metaphor. A class is a cookie cutter, a template design. When attached to a GameObject, it becomes a Component, which is one real cookie made by the cutter. Member variables are traits of the cookie like flavor and size. Methods are actions the cookie can perform, such as breaking or changing color. One cookie cutter (class) can make many different cookies (components), each with their own unique trait values.
Activity 3:
When the balls bounce repeatedly, their color value keeps getting overwritten and multiplied every collision. Each bounce increases the RGB color values continuously without an upper limit, so the color numbers keep rising past the normal 0–1 range. As RGB values grow higher than 1, the sprite becomes overexposed and appears extremely bright in the Scene view.

### W4
1. I added a Rigidbody to the Cat and the Ball so they could interact using Unity’s physics system. I used a Capsule Collider for the Cat, a Sphere Collider for the Ball, and a Box Collider for the Goal. I checked Is Trigger on the Goal’s collider so the game could detect when the Ball entered the goal area. I kept the Cat and Ball colliders as regular colliders so they could physically collide with each other and the ground.
2. During testing, I checked the collider sizes and positions to make sure they matched the objects. I also checked the Rigidbody settings and the Is Trigger option on the Goal. I fixed the settings so the Cat could interact with the Ball and the Ball could trigger the goal detection when it entered the goal area.

### W6
1. The DeerW5 class needs two member variables: Transform _target: Stores the Transform of the target GameObject. It is marked with [SerializeField] so that the target can be assigned in the Unity Inspector. NavMeshAgent _agent: Stores the NavMeshAgent component attached to the deer. It is used to control the deer’s movement.
2. The class needs the Unity-provided Start() method. I will also use GetComponent<NavMeshAgent>() to get the NavMeshAgent component from the deer GameObject. The Start() method is suitable because the deer only needs to receive its destination when the game begins
3. The Start() method should perform the following steps:Get the NavMeshAgent component attached to the deer. Get the position of the target GameObject. Use SetDestination() to tell the deer where to walk. Let the NavMeshAgent automatically calculate a path and move the deer towards the target.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
