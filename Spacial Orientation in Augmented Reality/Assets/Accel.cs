using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accel : MonoBehaviour{
	public static Accel Instance {set; get;}
	
	
	public float screenH;
	public float myx;
	public float myy;
	public float myz;
	public float secondz;
	public float objx;
	public float objy;
	public float objz;
	private float timeUpdate;
	
	void Start(){
		Instance = this;
		DontDestroyOnLoad(gameObject);
		screenH = Screen.height * 1.0f;
		timeUpdate = Time.fixedTime + 0.1f;
		secondz = (int)(Input.acceleration.z * 1000.0f) / 1000.0f;
	}
	
	void Update(){
		objx = this.transform.localRotation.z;
		objy = this.transform.localPosition.x;
		objz = this.transform.localPosition.y;
		myx = Input.acceleration.x;
		myy = Input.acceleration.y;
		myz = (int)(Input.acceleration.z * 1000.0f) / 1000.0f;
		
		transform.Rotate(0, 0, -1 * ((this.transform.localRotation.z - (Input.acceleration.x/2.0f))*25.0f));
		
		transform.Translate(-objy,(-1 * ((screenH * Mathf.Lerp(myz, secondz, 0.5f)) + objz))/20.0f, 0);
		if(Time.fixedTime >= timeUpdate){
			secondz = (int)(Input.acceleration.z * 1000.0f) / 1000.0f;
			timeUpdate = Time.fixedTime + 0.1f;
		}


		//local acceleration x <-- (-) (+) -->
		//position must equal local position x - acceleration x
	}

}