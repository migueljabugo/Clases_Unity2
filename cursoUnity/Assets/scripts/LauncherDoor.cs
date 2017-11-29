using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherDoor : MonoBehaviour {

	private MeshRenderer renderer;
	private BoxCollider collider;


	void Start () {
		collider = gameObject.GetComponent<BoxCollider> ();
		renderer = gameObject.GetComponent<MeshRenderer> ();
		SetState (true);

		
	}

	void OnTriggerExit(Collider ballCollider){
		SetState (false);
	}

	public void SetState(bool open){
		collider.isTrigger = open;
		renderer.enabled = !open;
	}
}
