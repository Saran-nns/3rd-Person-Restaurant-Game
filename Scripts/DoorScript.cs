using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	public bool open=false;
	public float openAngle=-160f;
	public float closeAngle=0f;
	public float doorSpeed=2f;

	// Use this for initialization
	void Start () {
	
	}
	public void ChangeDoorState()
	{
		open = !open;

	}

	void Update () {
		if (open) {
		
			Quaternion targetRotation = Quaternion.Euler (0, openAngle, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, doorSpeed * Time.deltaTime);
		} 
		else
		{
			Quaternion targetRotation2 = Quaternion.Euler (0, closeAngle, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation2, doorSpeed * Time.deltaTime);
		}
	
	}
}
