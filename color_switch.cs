using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_switch : MonoBehaviour
{
    [HideInInspector] public int index = 0;
    Transform wheel;

    public float turningRate = 60f;
    Quaternion targetRotation;

    // Set the rotating element and rotation amount
    private void Start()
    {
        wheel = transform.GetChild(0);
        targetRotation = Quaternion.Euler(0, -90, 90f + index * 120f);

    }

    // Rotates to target location
    private void Update()
    {
        wheel.localRotation = Quaternion.RotateTowards(wheel.localRotation, targetRotation, turningRate * Time.deltaTime);
    }

    // Sets the next position for the object
    public void ChangeMaterial()
    {
        index++;
        if (index == 3) index = 0;
        targetRotation = Quaternion.Euler(0, -90, 90f+ index*120f);


    }
}
