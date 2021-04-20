using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : ObjectBehavior
{
    public override void Start()
    {
        this.initPosition = GameObject.Find("RockSphere").transform;
    }
}
