using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBrick : Brick
{
    // Start is called before the first frame update
    protected override void Start()
    {
        brickColor = Color.green;
        PointValue = 1;

        base.Start();
    }
}
