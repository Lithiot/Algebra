using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    record rec;
    private Text tx;

    private void Awake()
    {
        rec = GameObject.FindGameObjectWithTag("ScoreRecorder").GetComponent<record>();
        tx = GetComponent<Text>();
    }

    private void Update()
    {
        tx.text = rec.Puntaje.ToString();
    }
}
