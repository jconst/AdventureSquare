using UnityEngine;
using System.Collections.Generic;

public class KeyConfig 
{
    public static Dictionary<KeyCode, Vector2> HeadingForKey = 
              new Dictionary<KeyCode, Vector2> {
        {KeyCode.UpArrow,    new Vector2(0, 1)},
        {KeyCode.DownArrow,  new Vector2(0, -1)},
        {KeyCode.LeftArrow,  new Vector2(-1, 0)},
        {KeyCode.RightArrow, new Vector2(1, 0)}
    };

    public static Dictionary<KeyCode, Vector2> GravityForKey = 
              new Dictionary<KeyCode, Vector2> {
        {KeyCode.W, new Vector2(0, 1)},
        {KeyCode.S, new Vector2(0, -1)},
        {KeyCode.A, new Vector2(-1, 0)},
        {KeyCode.D, new Vector2(1, 0)}
    };
}
