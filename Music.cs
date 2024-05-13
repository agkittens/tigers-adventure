using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Music initializer
public class Music : MonoBehaviour
{
    private Music instance = null;

    private void Awake()
    { 

        if (instance != null)
        {
            Destroy(gameObject);
        }

        else{
            instance =  this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }

}
