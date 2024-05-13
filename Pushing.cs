using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushing : MonoBehaviour
{

    [SerializeField]
    private float forceMagnitude;


    // Applies force to the object that has been collided with
    private void OnControllerColliderHit(ControllerColliderHit hit){

        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if (rigidbody != null){

            Vector3 forceDir = hit.gameObject.transform.position - transform.position;
            forceDir.y = 0;
            forceDir.Normalize();

            rigidbody.AddForceAtPosition(forceDir*forceMagnitude, transform.position, ForceMode.Impulse);
        }
    }
}
