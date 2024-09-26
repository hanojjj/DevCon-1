# DevCon-1

### Desired Game Mechanic

Our desired game mechanic is "Freezeing Platforms" withing a 2D platformer.

### Objective Statement

Playable moving platform level that features freezing of the current platform row the player lands on.
Add more here!

### Design Rationale

The experience envisioned was to take your normal platformer and add a bit of a spin to it. The player is expected to have to adjust their normal movement and take a slower approach. 
It's experimental because most people who play platformers tend to move very fast. Also, being a large part of the speedrunning community. This changes how people will have to approach the level.

### Rules

- Players jump resets after colliding with the ground
- Only the row of platforms the player is on will freeze
- Player can only move right/left and jump
- Frozen platforms delayed by a second when jumped off of (possibly) 

### Methods
- Create multiple rows of platforms either moving up or down infinitely
- Player lands on a platform and it freezes that row
- Player must time their jump correctly 
- Make it to the other side
- UI to display controls (depending on time) 

#### Platform Moving Script (Starting down)
There is a separate script for platforms that start moving up, although its very similar.
```C#
public class PlatformMovingDown : MonoBehaviour
{

    public float min = 2f;
    public float max = 3f;


    // Start is called before the first frame update
    void Start()
    {
       min = transform.position.y; 
       max = transform.position.y +10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time *2 - 10f, max - min) + min);
    }
}
```


### Resources

TBA
