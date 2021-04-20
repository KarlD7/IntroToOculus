using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class ObjectBehavior : MonoBehaviour
{
    public GameObject objectPrefab;
    public Transform initPosition;

    public abstract void Start();
 
    public void replaceObject()
    {
        Instantiate(objectPrefab, initPosition);
    }
}
