using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour {

    public static TransformPosition instanciate;


    [HideInInspector]public Vector3 Position;
    private Vector3 originalPosition;
    public bool PositionX = false;
    public int FinalPositionX;
    public bool PositionY = false;
    public int FinalPositionY;
    public bool PositionZ = false;
    public int FinalPositionZ;

    public int PositionSpeed;

    // Use this for initialization
    void Start()
    {
        instanciate = this;
        Position = transform.position;
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (PositionX)
        {
            if (FinalPositionX < originalPosition.x)
            {
                if (transform.position.x <= originalPosition.x && transform.position.x >= FinalPositionX)
                {
                    Position.x -= Time.deltaTime * PositionSpeed;
                }
            }
            else
            {
                if (transform.position.x >= originalPosition.x && transform.position.x <= FinalPositionX)
                {
                    Position.x += Time.deltaTime * PositionSpeed;
                }
            }
        }

        if (PositionY)
        {
            if (FinalPositionY < originalPosition.y)
            {
                if (transform.position.y <= originalPosition.y && transform.position.y >= FinalPositionY)
                {
                    Position.y -= Time.deltaTime * PositionSpeed;
                }
            }
            else
            {
                if (transform.position.y >= originalPosition.y && transform.position.y <= FinalPositionY)
                {
                    Position.y += Time.deltaTime * PositionSpeed;
                }
            }
        }

        if (PositionZ)
        {
            if (FinalPositionZ < originalPosition.z)
            {
                if (transform.position.z <= originalPosition.z && transform.position.z >= FinalPositionZ)
                {
                    Position.z -= Time.deltaTime * PositionSpeed;
                }
            }
            else
            {
                if (transform.position.z >= originalPosition.z && transform.position.z <= FinalPositionZ)
                {
                    Position.z += Time.deltaTime * PositionSpeed;
                }
            }
        }

        transform.position = Position;

    }


}