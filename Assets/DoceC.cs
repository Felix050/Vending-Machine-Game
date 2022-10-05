using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoceC : MonoBehaviour
{
    public static event Action DoorCanBeOpened = delegate { };

    private bool mouseButtonReleased;

    private void OnMouseDown()
    {
        mouseButtonReleased = false;
    }

    private void OnMouseUp()
    {
        mouseButtonReleased = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Door" && mouseButtonReleased)
        {
            DoorCanBeOpened();
            Destroy(gameObject);
        }
    }
}