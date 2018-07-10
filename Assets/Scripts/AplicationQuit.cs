using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicationQuit : MonoBehaviour {

    public void Close()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
