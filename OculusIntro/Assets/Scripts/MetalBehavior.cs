using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalBehavior : ObjectBehavior
{
    public override void Start()
    {
        this.initPosition = GameObject.Find("MetalSphere").transform;
    }

}
