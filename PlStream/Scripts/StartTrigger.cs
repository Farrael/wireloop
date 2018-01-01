using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour {

	private Timer time;
	private AudioSource startAudio;

	// Use this for initialization
	void Awake () {
		time = GameObject.Find("Canvas").GetComponent<Timer>();
		startAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		//Debug.Log(other.ClosestPoint);
		if(time.count == false)
		{
			Debug.Log("GOOOO");
	        startAudio.Play();
	        time.time = 0;
	        time.count = true;
		}
    }
}
