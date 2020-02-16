using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitControlB : MonoBehaviour {

    public Transform TheRabbit;
	public bool Hit = false;
	public float CurrentPos = 0.0f;
	public float RotateSpeed = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!Hit && this.gameObject.transform.position.z > TheRabbit.position.z)
		{
			Hit = true;
			CurrentPos = (TheRabbit.eulerAngles.y - 180) % 360;
		}
			
	    if(Hit)
		{
		    TheRabbit.eulerAngles = new Vector3(TheRabbit.eulerAngles.x, 
											Mathf.LerpAngle(TheRabbit.eulerAngles.y, CurrentPos, Time.deltaTime * RotateSpeed), 
											TheRabbit.eulerAngles.z);
			if(TheRabbit.position.z >  this.gameObject.transform.position.z)
			{
				Hit = false;
				CurrentPos = 0;
			}
		}
	}
}
