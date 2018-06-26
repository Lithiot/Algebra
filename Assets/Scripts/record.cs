using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class record : MonoBehaviour {

    public float Puntaje;
    public static record instantiate;

    private void Awake()
    {
        if (instantiate == null)
        {
            instantiate = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
