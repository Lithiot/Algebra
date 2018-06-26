using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotation : MonoBehaviour {

    public static TransformRotation instanciate;

    [HideInInspector]public Vector3 Rotation;

    [SerializeField] private bool RotationX = false;
    [SerializeField] private float FinalRotationX;
    private float AuxFinalRotationX;
    [SerializeField] private bool RotationY= false;
    [SerializeField] private float FinalRotationY;
    private float AuxFinalRotationY;
    [SerializeField] private bool RotationZ = false;
    [SerializeField] private float FinalRotationZ;
    private float AuxFinalRotationZ;
    [SerializeField] private bool reinicio = false;

    public int RotationSpeed;

    public bool Reinicio
    {
        set
        {
            reinicio = value;
        }
    }

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
        if (reinicio)
        {
            AuxFinalRotationX = FinalRotationX;
            AuxFinalRotationY = FinalRotationY;
            AuxFinalRotationZ = FinalRotationZ;
            Rotation = transform.eulerAngles;
            reinicio = false;
        }

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
