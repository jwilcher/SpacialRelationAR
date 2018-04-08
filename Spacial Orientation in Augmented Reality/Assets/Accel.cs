using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accel : MonoBehaviour{
	public static Accel Instance {set; get;}
	
	public float myx;
	public float myy;
	public float myz;
	public float objx;
	public float objy;
	public float objz;
	
	void Start(){
		Instance = this;
		DontDestroyOnLoad(gameObject);
	}
	
	void Update(){
		myx = Input.acceleration.x;
		myy = Input.acceleration.y;
		myz = Input.acceleration.z;
		objx = this.transform.localRotation.x;
		objy = this.transform.localRotation.y;
		objz = this.transform.localRotation.z;
		transform.Rotate(0, 0, -1 * ((this.transform.localRotation.z - (Input.acceleration.x/2.0f))*5.0f));
	}

}