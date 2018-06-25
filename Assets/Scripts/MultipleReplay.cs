using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleReplay : MonoBehaviour {

    [SerializeField] private GameObject Dice1;
    [SerializeField] private GameObject Dice2;
    [SerializeField] private GameObject Dice3;

    private TransformRotation rot1;
    private TransformRotation rot2;
    private TransformRotation rot3;

    private void Awake()
    {
        rot1 = Dice1.GetComponent<TransformRotation>();
        rot2 = Dice2.GetComponent<TransformRotation>();
        rot3 = Dice3.GetComponent<TransformRotation>();
    }

    public void DiceRestart()
    {
        TransformPosition.instanciate.Position = Vector3.zero;
        Dice1.transform.rotation = Quaternion.identity;
        TransformScale.instanciate.scale = Vector3.one;
        rot1.Reinicio = true;

        TransformPosition.instanciate.Position = Vector3.zero;
        Dice2.transform.rotation = Quaternion.identity;
        TransformScale.instanciate.scale = Vector3.one;
        rot2.Reinicio = true;

        TransformPosition.instanciate.Position = Vector3.zero;
        Dice3.transform.rotation = Quaternion.identity;
        TransformScale.instanciate.scale = Vector3.one;
        rot3.Reinicio = true;
    }
}
