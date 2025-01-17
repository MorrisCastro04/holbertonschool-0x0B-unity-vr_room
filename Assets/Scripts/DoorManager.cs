using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorManager : MonoBehaviour
{
    public Animator doorAnimator;
    bool doorOpen = false;

    public void OpenDoor()
    {
        if (doorOpen)
        {
            doorAnimator.SetBool("character_nearby", false);
            doorOpen = false;
        }
        else
        {
            doorAnimator.SetBool("character_nearby", true);
            doorOpen = true;
        }
    }
}
