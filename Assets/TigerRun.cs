using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerRun : MonoBehaviour {

	public float Speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate( 0, 0, Speed * Time.deltaTime);
		
	}
}
