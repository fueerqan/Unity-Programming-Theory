using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBrick : Brick
{
    // Start is called before the first frame update
    protected override void Start()
    {
        brickColor = Color.white;
        PointValue = 4;

        base.Start();
    }
}
