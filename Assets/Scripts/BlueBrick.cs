using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBrick : Brick
{
    // Start is called before the first frame update
    protected override void Start()
    {
        brickColor = Color.blue;
        PointValue = 2;

        base.Start();
    }
}
