using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleReplay : MonoBehaviour
{

    [SerializeField] private GameObject dice1;
    [SerializeField] private GameObject dice2;
    [SerializeField] private GameObject dice3;
    private TransformRotation rot1;
    private TransformRotation rot2;
    private TransformRotation rot3;

    private void Awake()
    {
        if (rot1 != null)
            rot1 = dice1.GetComponent<TransformRotation>();
        if (rot2 != null)
            rot2 = dice1.GetComponent<TransformRotation>();
        if (rot3 != null)
            rot3 = dice1.GetComponent<TransformRotation>();
       
    }

    public void DiceRestart()
    {
        TransformPosition.instanciate.Position = Vector3.zero;
        dice1.transform.rotation = Quaternion.identity;
        TransformScale.instanciate.scale = Vector3.one;
        rot1.Reinicio = true;

        TransformPosition.instanciate.Position = Vector3.zero;
        dice2.transform.rotation = Quaternion.identity;
        TransformScale.instanciate.scale = Vector3.one;
        rot2.Reinicio = true;

        TransformPosition.instanciate.Position = Vector3.zero;
        dice3.transform.rotation = Quaternion.identity;
        TransformScale.instanciate.scale = Vector3.one;
        rot3.Reinicio = true;
    }
}
