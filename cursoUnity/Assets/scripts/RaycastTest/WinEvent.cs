using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinEvent : MonoBehaviour {

	public MovetoTarget moveTo;

	void Start(){
		moveTo = GetComponentInParent <MovetoTarget> ();
	}

	public void DestroyBall(){
		moveTo.DestroyTarget ();
	}

	public void OnHelloAnimationFinished(){
		moveTo.Activate ();
	}

}
