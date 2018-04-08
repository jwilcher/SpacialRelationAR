using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateAccel : MonoBehaviour{
	public Text thePosition;
	
	private void Update(){
		thePosition.text = ""+ Accel.Instance.myx +"\n"+ Accel.Instance.myy +"\n"+ Accel.Instance.myz +"\n"+ Accel.Instance.objx +"\n"+ Accel.Instance.objy +"\n"+ Accel.Instance.objz +"\n";
	}
}