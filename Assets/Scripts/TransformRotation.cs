using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotation : MonoBehaviour {

    public static TransformRotation instanciate;

    [HideInInspector]public Vector3 Rotation;

    public bool RotationX = false;
    public float FinalRotationX;
    private float AuxFinalRotationX;
    public bool RotationY= false;
    public float FinalRotationY;
    private float AuxFinalRotationY;
    public bool RotationZ = false;
    public float FinalRotationZ;
    private float AuxFinalRotationZ;

    public int RotationSpeed;

    void Start()
    {
        instanciate = this;
        AuxFinalRotationX = FinalRotationX;
        AuxFinalRotationY = FinalRotationY;
        AuxFinalRotationZ = FinalRotationZ;
        Rotation = transform.eulerAngles;
    }

    void Update()
    {
        if (RotationX)
        {
            if (AuxFinalRotationX > 0)
            {
                AuxFinalRotationX -= Time.deltaTime * RotationSpeed;
                Rotation.x += Time.deltaTime * RotationSpeed;
            }
            if (AuxFinalRotationX < 0)
            {
                AuxFinalRotationX += Time.deltaTime * RotationSpeed;
                Rotation.x -= Time.deltaTime * RotationSpeed;
            }
        }

        if (RotationY)
        {
            if (AuxFinalRotationY > 0)
            {
                AuxFinalRotationY -= Time.deltaTime * RotationSpeed;
                Rotation.y += Time.deltaTime * RotationSpeed;
            }
            if (AuxFinalRotationY < 0)
            {
                AuxFinalRotationY += Time.deltaTime * RotationSpeed;
                Rotation.y -= Time.deltaTime * RotationSpeed;
            }
        }

        if (RotationZ)
        {
            if (AuxFinalRotationZ > 0)
            {
                AuxFinalRotationZ -= Time.deltaTime * RotationSpeed;
                Rotation.z += Time.deltaTime * RotationSpeed;
            }
            if (AuxFinalRotationZ < 0)
            {
                AuxFinalRotationZ += Time.deltaTime * RotationSpeed;
                Rotation.z -= Time.deltaTime * RotationSpeed;
            }
        }

        transform.eulerAngles = Rotation;
    }
}
