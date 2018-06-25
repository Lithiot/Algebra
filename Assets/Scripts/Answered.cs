using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answered : MonoBehaviour {

    private bool ans;
    [SerializeField] private GameObject nextBtn;

    public bool Ans
    {
        get
        {
            return ans;
        }

        set
        {
            ans = value;
        }
    }

    private void Update()
    {
        if (ans)
        {
            nextBtn.SetActive(true);
        }
    }
}
