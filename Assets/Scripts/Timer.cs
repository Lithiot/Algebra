using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{
    private float time;
    private Slider sl;
    [SerializeField] private Answered pr;
    private bool resolved;

    public bool Resolved
    {
        set
        {
            resolved = value;
        }
    }

    public float Time
    {
        get
        {
            return time;
        }
    }

    private void Awake()
    {
        sl = GetComponent<Slider>();
        time = sl.value;
    }

    private void Update()
    {
        if (!pr.Ans)
        {
            time -= UnityEngine.Time.deltaTime;
            sl.value = Time;
            if (Time <= 0)
                pr.Ans = true;
        }
    }
}
