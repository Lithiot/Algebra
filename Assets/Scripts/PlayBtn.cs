using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayBtn : MonoBehaviour {

    [SerializeField] private string game;

    private void Awake()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Quit);
    }

    private void Quit()
    {
        SceneManager.LoadScene(game);
    }
}
