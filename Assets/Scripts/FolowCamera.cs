using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowCamera : MonoBehaviour {
    public GameObject Target;
    //public Vector3 TargetDistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = Target.transform.position - TargetDistance;
        transform.LookAt(Target.transform);
	}
}
