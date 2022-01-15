using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Brick : MonoBehaviour
{
    public UnityEvent<int> onDestroyed;
    
    protected int PointValue;
    protected Color brickColor;
    protected MaterialPropertyBlock block;

    protected virtual void Start()
    {
        var renderer = GetComponentInChildren<Renderer>();
        block = new MaterialPropertyBlock();
        block.SetColor("_BaseColor", brickColor);

        renderer.SetPropertyBlock(block);
    }

    private void OnCollisionEnter(Collision other)
    {
        onDestroyed.Invoke(PointValue);
        
        //slight delay to be sure the ball have time to bounce
        Destroy(gameObject, 0.2f);
    }
}
