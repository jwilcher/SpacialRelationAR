using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroControl : MonoBehaviour{
	private bool gyroEnabled;
	private Gyroscope gyro;
	public Text orientation;
	
	private GameObject cameraContainer;
//	public GameObject horizon;
//	private Quaternion rot;
	
	private void Start(){
		cameraContainer = new GameObject("Camera Container");
//		horizon = new GameObject("Horizon");
		cameraContainer.transform.position = transform.position;
//		horizon.transform.position = transform.position;
		transform.SetParent(cameraContainer.transform);
		gyroEnabled = EnableGyro();
		
	}
	
	private bool EnableGyro(){
		if(SystemInfo.supportsGyroscope){
			gyro = Input.gyro;
			gyro.enabled = true;
			
			cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
//			horizon.transform.rotation = Quaternion.Euler(90f, 90f, 0f); 
//			rot = new Quaternion(0, 0, 1, 0);
			return true;
		}
		return false;
	}
	
	private void Update(){
		if(gyroEnabled){
//			transform.localRotation = gyro.attitude * rot;
//			transform.localRotation = gyro.attitude;
			orientation.text = "Gyro\nX: " + gyro.attitude.x.ToString() + "\nY: " + gyro.attitude.y.ToString() + "\nZ:" + gyro.attitude.z.ToString() + "\nW:" + gyro.attitude.w.ToString();
		}
		
		
	}
}