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
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
