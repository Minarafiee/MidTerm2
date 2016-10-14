using UnityEngine;
using System.Collections;

public class metronum : MonoBehaviour {

	public  Vector3 rotationDegrees;
	public  float rotationSpeed=-5.0f ;
	bool isAngleMovingTowardsPos = true;
	 

	// Use this for initialization
	void Update(){
	 
		if (transform.localEulerAngles.z < -45.0f && isAngleMovingTowardsPos == false) {
			isAngleMovingTowardsPos = true;
			rotationDegrees = new Vector3 (0, 0, rotationSpeed); 

		}

		if (transform.localEulerAngles.z > 45.0f && isAngleMovingTowardsPos == true) {
			isAngleMovingTowardsPos = false;
			transform.localEulerAngles.z -= rotationSpeed; 
		}

		rotationDegrees = transform.localEulerAngles;


	}
//		if ( transform.rotationDegrees > +45) {
//			// transform.localEulerAngles = negative
//		 rotationSpeed= -5f;
//		}
//	}
//
//
//		//add currentSpeed to rotationDegrees (use +=)
//	rotationSpeed+= new rotationDegrees
//
//		// this is where we actually apply the rotation and turn it... do NOT use transform.Rotate
//		// you will need to tweak the numbers here to make it look right, e.g. it might be upside down at first
//
//		transform.localEulerAngles(0,0, rotationDegrees);
//		//set transform.localEulerAngles to (0, 0, rotationDegrees)
//
//
}
