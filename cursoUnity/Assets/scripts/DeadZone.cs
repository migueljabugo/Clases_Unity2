using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

	public Transform spawnBallPosition;
	public LauncherDoor launcherDoor;
	public ScoreManager manager;


	void OnTriggerEnter(Collider ballCollider){
		Debug.Log ("Ha entrado");
		manager.ResetScore ();
		Debug.Log ("Abriendo puerta lanzador");
		launcherDoor.SetState(true);

		GameObject ball = ballCollider.gameObject;
		//Mover bola al punto de spawn
		ball.transform.position = spawnBallPosition.position;
		ball.transform.rotation = spawnBallPosition.rotation;
		Debug.Log ("Bola movida al spawn");
		//Poner a cero las velocidades del rigidbody
		Rigidbody rb = ball.GetComponent<Rigidbody>();
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		Debug.Log ("Velocidades y direccion reseteadas");
		//Acceder al componente Ball Launcher de la bola y la variable fired ponerla a false
		BallLauncher launcher = ball.GetComponent<BallLauncher>();
		launcher.fired = false;
		
	}





}
