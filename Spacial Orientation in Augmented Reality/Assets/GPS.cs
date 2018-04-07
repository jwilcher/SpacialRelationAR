using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour{
	public static GPS Instance {set; get;}
	
	public float latitude;
	public float longitude;
	public float heading;
	private float timeUpdate;
	
	private void Start(){
		timeUpdate = Time.fixedTime + 0.5f;
		Instance = this;
		DontDestroyOnLoad(gameObject);
		StartCoroutine(StartLocationService());
	}
	
	private IEnumerator StartLocationService(){
		if(!Input.location.isEnabledByUser){
			UnityEngine.Debug.Log("GPS services not currently enabled");
			yield break;
		}
		Input.compass.enabled = true;
		Input.location.Start();
		int timeToOut = 30;
		while(Input.location.status == LocationServiceStatus.Initializing && timeToOut > 0){
			yield return new WaitForSeconds(1);
			timeToOut--;
		}
		if(timeToOut<=0){
			UnityEngine.Debug.Log("GPS Initializing Timed Out");
			yield break;
		}
		if(Input.location.status == LocationServiceStatus.Failed){
			UnityEngine.Debug.Log("Unable to ascertain location");
			yield break;
		}
		
		yield break;
	}
	
	private void FixedUpdate(){
		if(Time.fixedTime >= timeUpdate){
			latitude = Input.location.lastData.latitude;
			longitude = Input.location.lastData.longitude;
			heading = Input.compass.trueHeading;
			timeUpdate = Time.fixedTime + 0.5f;
		}
	}
}