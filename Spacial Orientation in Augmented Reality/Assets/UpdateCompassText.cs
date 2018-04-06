using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCompassText : MonoBehaviour{
	public Text heading;
	
	private void Update(){
		int bearing = Mathf.RoundToInt(GPS.Instance.heading);
		char nsew = 'X';
		if(bearing >= 315 || bearing < 45){
			nsew = 'N';
		}else if(bearing >= 45 && bearing < 135){
			nsew = 'E';
		}else if(bearing >= 135 && bearing < 225){
			nsew = 'S';
		}else if(bearing >= 225 && bearing < 315){
			nsew = 'W';
		}
		heading.text = "     " + nsew + "\n" +bearing.ToString();
//		heading.text = "     " + "\n" +GPS.Instance.heading.ToString();
	}
	
}