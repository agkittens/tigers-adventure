using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class button_script : MonoBehaviour
{
    Vector3 startPos;
    Vector3 endPos;
    public float duration;

    [HideInInspector] public bool isActive;
    float startTime;
    Transform obj;

    public UnityEvent pressed;

    // Initializes movement variables
    void Start()
    { 
        obj = transform.GetChild(2);
        startPos = obj.position;
        endPos = startPos + new Vector3(0f, -0.3f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {

            // Interpolates for smooth movement and waits for the duration specified
            if (Time.time - startTime < duration)
            {
                float ratio = (Time.time - startTime) / 0.2f;
                Vector3 interpolation = Vector3.Lerp(startPos, endPos, ratio);
                obj.position = interpolation;
            }
            else
            {
                float ratio = (Time.time - startTime - duration) / 0.2f;
                Vector3 interpolation = Vector3.Lerp(endPos, startPos, ratio);
                obj.position = interpolation;
                if (ratio > 1)
                {
                    isActive = false;
                }
            }
        }
    }

    // button trigger
    private void OnTriggerStay(Collider other)
    {
        if (!isActive)
        {
            pressed.Invoke();
            startTime = Time.time;
            isActive = true;

        }
    }
}
