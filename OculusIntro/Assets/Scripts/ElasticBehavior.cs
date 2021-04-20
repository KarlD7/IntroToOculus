using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElasticBehavior : ObjectBehavior
{
    public override void Start()
    {
        this.initPosition = GameObject.Find("ElasticSphere").transform;
    }
}
