using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBrick : Brick
{
    // Start is called before the first frame update
    protected override void Start()
    {
        brickColor = Color.red;
        PointValue = 5;

        base.Start();
    }
}
