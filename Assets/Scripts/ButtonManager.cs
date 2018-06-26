using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    [SerializeField] private GameObject dice;
    private TransformRotation rot;

    private void Awake()
    {
        if (rot != null)
            rot = dice.GetComponent<TransformRotation>();
    }

    public void RestarDice()
    {
        
        TransformPosition.instanciate.Position = Vector3.zero;
        dice.transform.rotation = Quaternion.identity;
        TransformScale.instanciate.scale = Vector3.one;
        rot.Reinicio = true;
    }
}
