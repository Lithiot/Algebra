using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScale : MonoBehaviour {

    public static TransformScale instanciate;


    [HideInInspector]public Vector3 scale;
    private Vector3 originalScale;
    public bool scaleX = false;
    public int FinalScaleX;
    public bool scaleY = false;
    public int FinalScaleY;
    public bool scaleZ = false;
    public int FinalScaleZ;

    public int ScaleSpeed;
    // Use this for initialization
    void Start () {
        instanciate = this;
        scale = transform.lossyScale;
        originalScale = transform.lossyScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (scaleX)
        {
            if (FinalScaleX < originalScale.x)
            {              
                if (transform.localScale.x <= originalScale.x && transform.localScale.x >= FinalScaleX)
                {
                    scale.x -= Time.deltaTime * ScaleSpeed;
                }
            }
            else
            {    
                if (transform.localScale.x >= originalScale.x && transform.localScale.x <= FinalScaleX)
                {
                    scale.x += Time.deltaTime * ScaleSpeed;
                }
            }
        }

        if (scaleY)
        {
            if (FinalScaleY < originalScale.y)
            {
                if (transform.localScale.y <= originalScale.y && transform.localScale.y >= FinalScaleY)
                {
                    scale.y -= Time.deltaTime * ScaleSpeed;
                }
            }
            else
            {
                if (transform.localScale.y >= originalScale.y && transform.localScale.y <= FinalScaleY)
                {
                    scale.y += Time.deltaTime * ScaleSpeed;
                }
            }
        }

        if (scaleZ)
        {
            if (FinalScaleZ < originalScale.z)
            {
                if (transform.localScale.z <= originalScale.z && transform.localScale.z >= FinalScaleZ)
                {
                    scale.z -= Time.deltaTime * ScaleSpeed;
                }
            }
            else
            {
                if (transform.localScale.z >= originalScale.z && transform.localScale.z <= FinalScaleZ)
                {
                    scale.z += Time.deltaTime * ScaleSpeed;
                }
            }
        }
        
        transform.localScale = scale;

    }


}
