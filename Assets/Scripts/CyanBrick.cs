using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanBrick : Brick
{
    // Start is called before the first frame update
    protected override void Start()
    {
        brickColor = Color.cyan;
        PointValue = 3;

        base.Start();
    }
}
