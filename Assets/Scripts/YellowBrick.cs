using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBrick : Brick
{
    // Start is called before the first frame update
    protected override void Start()
    {
        brickColor = Color.yellow;
        PointValue = 2;

        base.Start();
    }
}
