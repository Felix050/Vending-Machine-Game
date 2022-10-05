using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        arrow.SetActive(false);
        //Key.DoorCanBeOpened += OpenDoor;
        DoceA.DoorCanBeOpened += OpenDoor;
        DoceB.DoorCanBeOpened += OpenDoor;
        DoceC.DoorCanBeOpened += OpenDoor;

    }

    private void OpenDoor()
    {
        arrow.SetActive(true);
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        //Key.DoorCanBeOpened -= OpenDoor;
        DoceA.DoorCanBeOpened -= OpenDoor;
        DoceB.DoorCanBeOpened -= OpenDoor;
        DoceC.DoorCanBeOpened -= OpenDoor;
    }
}
