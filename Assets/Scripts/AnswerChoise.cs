using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerChoise : MonoBehaviour
{
    [SerializeField] private bool correct;
    private record rec;
    [SerializeField] private Answered pr;
    private Button btn;
    private Image img;

    private void Awake()
    {
        rec = GameObject.FindGameObjectWithTag("ScoreRecorder").GetComponent<record>();
        btn = GetComponent<Button>();
        img = GetComponent<Image>();
        btn.onClick.AddListener(Check);
    }

    private void Check()
    {
        if (correct)
            rec.Puntaje += 1;
        pr.Ans = true;
    }

    private void Update()
    {
        if (pr.Ans)
        {
            Destroy(btn);
            if (correct)
                img.color = Color.green;
            else
                img.color = Color.red;
        }
    }
}
