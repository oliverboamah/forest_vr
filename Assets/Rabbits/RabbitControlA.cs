using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitControlA : MonoBehaviour {

    public Transform[] TheRabbit;
	public bool Hit = false;
	public float CurrentPos = 0.0f;
	public float RotateSpeed = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	    for(int I = 0, J = TheRabbit.Length; I < J; I++)
		{
			if (!Hit && this.gameObject.transform.position.z < TheRabbit[I].position.z)
			{
				Hit = true;
				CurrentPos = (TheRabbit[I].eulerAngles.y + 180) % 360;
			}
				
		    if(Hit)
			{
			    TheRabbit[I].eulerAngles = new Vector3(TheRabbit[I].eulerAngles.x, 
												Mathf.LerpAngle(TheRabbit[I].eulerAngles.y, CurrentPos, Time.deltaTime * RotateSpeed), 
												TheRabbit[I].eulerAngles.z);
				if(TheRabbit[I].position.z <  this.gameObject.transform.position.z)
				{
					Hit = false;
					CurrentPos = 0;
				}
			}
		}
	}
}
