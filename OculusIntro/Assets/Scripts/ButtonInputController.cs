using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonInputController : MonoBehaviour
{
    public UnityEvent ButtonDownEvent = new UnityEvent();
    public UnityEvent ButtonUpEvent = new UnityEvent();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ButtonDownEvent.Invoke();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ButtonUpEvent.Invoke();
        }
    }
}