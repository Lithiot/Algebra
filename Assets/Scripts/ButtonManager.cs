using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    [SerializeField] private GameObject Dice;
    private TransformRotation rot;

    private void Awake()
    {
        rot = Dice.GetComponent<TransformRotation>();
    }

    public void RestarDice()
    {
        
        TransformPosition.instanciate.Position = Vector3.zero;
        Dice.transform.rotation = Quaternion.identity;
        TransformScale.instanciate.scale = Vector3.one;
        rot.Reinicio = true;
    }
}
