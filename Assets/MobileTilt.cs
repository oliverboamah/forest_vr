using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileTilt : MonoBehaviour {

	 // Move object using accelerometer
    public float RotateSpeed = 130f;
    public float FrontSpeed = 5f;
    public float BackSpeed = 5f;
	
     void Start ()
     {
     }
	 
     void FixedUpdate ()
	 {
        Vector3 dir = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();
			
	     if (dir.x > 0.2 || dir.x < -0.2)
	  	   transform.Rotate(0, dir.x * RotateSpeed * Time.deltaTime, 0);
		   
	   if (dir.z > -0.4)
	   {
		   
	     if (dir.z > -0.2 && dir.z < 0.2)
		 	transform.Translate(0, 0, FrontSpeed * Time.deltaTime);
		 else if(dir.z > 0.2)
			transform.Translate(0, 0, -BackSpeed * Time.deltaTime);
			
		//transform.Translate(0, 0, -dir.y * FrontSpeed * (1 - Mathf.Clamp01(Mathf.Round(Mathf.Abs(dir.z) * 10) / 10)) * Time.deltaTime/2);
	   }
	 
	  // Debug.Log(Mathf.Round(dir.x*10)/10 + "  " + Mathf.Round(dir.y*10)/10 + "    "+Mathf.Round(dir.z*10)/10 + "    " + Input.deviceOrientation + "      "+ (-dir.y * FrontSpeed * Time.deltaTime));
    }
}
