using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class record : MonoBehaviour {

    private int puntaje;

    public int Puntaje
    {
        get
        {
            return puntaje;
        }

        set
        {
            puntaje = value;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

}
