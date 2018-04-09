using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateAccel : MonoBehaviour{
	public Text thePosition;
	
	private void Update(){
		thePosition.text = ""+ Accel.Instance.myx +"\n"+ Accel.Instance.myy +"\n"+ Accel.Instance.myz +"\nRot X: "+ Accel.Instance.objx +"\nPos X: "+ Accel.Instance.objy +"\nPos Y: "+ Accel.Instance.objz +"\nScreenH: "+ Accel.Instance.screenH;
	}
}