using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPSText : MonoBehaviour{
	public Text coordinates;
	
	private void Update(){
		coordinates.text = "" + GPS.Instance.latitude.ToString() + " : Lat\n" + GPS.Instance.longitude.ToString() + " :Lon";
	}
}