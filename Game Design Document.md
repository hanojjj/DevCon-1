# DevCon-1

### Desired Game Mechanic

Our desired game mechanic is "**Freezing Platforms**" within a 2D platformer.

### Objective Statement

Playable moving platform level that features freezing of the current platform row the player lands on.

What happens when players are used to a certain _**speed of gameplay**_ and we add a mechanic that _**slows them down**_. When the world around them is affected by their movement how will they _**adapt their usual playstyle**_?

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

### Main Mechanic (Freezing Platforms)
This was put on the player movement script.
```C#
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform Up"))
        {

            platformOne.enabled = false;
            platformTwo.enabled = false;
            platformThree.enabled = false;
        }        
        if (collision.gameObject.CompareTag("Platform Down"))
        {

            platformFour.enabled = false;
            platformFive.enabled = false;
            platformSix.enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        platformOne.enabled = true;
        platformTwo.enabled = true;
        platformThree.enabled = true;
        platformFour.enabled = true;
        platformFive.enabled = true;
        platformSix.enabled = true;

    }
```

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

Character Sprite: https://assetstore.unity.com/packages/2d/characters/cute-2d-girl-wizard-155796

Background: https://assetstore.unity.com/packages/2d/environments/pixel-skies-demo-background-pack-226622

Mathf.PingPong Help: https://docs.unity3d.com/ScriptReference/Mathf.PingPong.html

GDD Example: https://drive.google.com/file/d/17-51Uwxqle3DZVleir6OhDlWA_aerw5g/view
