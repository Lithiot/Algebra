using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextBtn : MonoBehaviour
{
    [SerializeField] private string nxt;
    private Button btn;

    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(NextScene);
    }

    private void NextScene()
    {
        SceneManager.LoadScene(nxt);
    }
}
