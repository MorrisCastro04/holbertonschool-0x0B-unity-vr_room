using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorManager : MonoBehaviour
{
    public GameObject particles;
    bool isPlaying = false;
    public void StartParticles()
    {
        if (!isPlaying)
        {
            particles.SetActive(true);
            isPlaying = true;
        }
        else
        {
            particles.SetActive(false);
            isPlaying = false;
        }
    }
}
