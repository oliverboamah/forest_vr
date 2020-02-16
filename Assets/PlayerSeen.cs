using System.Collections.Generic;
using UnityEngine;

public class PlayerSeen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public GameObject Bfly;
	// Update is called once per frame
	void Update () 
	{
	}
		void OnTriggerEnter(Collider other)
  		{
        	if (other.tag == "Player")
            	Bfly.SetActive(true);
    	}
		void OnTriggerExit(Collider other)
  		{
        	if (other.tag == "Player")
            	Bfly.SetActive(false);
    	}
}
