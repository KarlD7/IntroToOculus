using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XRGUI : MonoBehaviour
{
    public Text throwDisplay;
    public int numThrows;

    public void Start()
    {
        numThrows = 0;
    }

    public void updateThrowDisplay()
    {
        numThrows += 1;
        throwDisplay.text = "Balls Thrown: " + numThrows;
    }

}
