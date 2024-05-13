using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    public GameObject Player;

    // Rotates camera to look at player
    void Update()
    {
        transform.LookAt(Player.transform);
    }
}
