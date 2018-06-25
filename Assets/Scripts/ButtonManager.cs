using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    [SerializeField] private GameObject Dice;

    public void RestarDice()
    {
        TransformPosition.instanciate.Position = Vector3.zero;
        TransformRotation.instanciate.Rotation = Vector3.zero;
        TransformScale.instanciate.scale = Vector3.one;
    }
}
