using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovetoTarget : MonoBehaviour {

	public NavMeshAgent agent;
	public Transform target;
	public Animator animator;
	public bool active;

	public Marcador marcadorRed;
	public Marcador marcadorBlue;
	public Marcador marcadorYellow;
	public Marcador marcadorGreen;

	AudioSource audioSource;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		animator = GetComponentInChildren<Animator> ();
		audioSource = GetComponent<AudioSource> ();

	}

	void Update () {
		Collider[] balls = Physics.OverlapSphere (transform.position, 50, LayerMask.GetMask ("balls"));
		//Debug.Log ( balls.Length);
		if (balls != null && balls.Length>0) {
			GameObject ball= GetNearetBall (balls);
			target = ball.transform;
			agent.SetDestination (ball.transform.position);
			agent.isStopped = false;

			if (agent.velocity.magnitude > 0.1f)
			{
				animator.SetBool ("moving", true);
			}
			else
			{
				animator.SetBool ("moving", false);

			}
		}else{
			agent.isStopped = true;
			animator.SetBool ("moving", false);

		}
		
		/*if (active && target != null) {
			agent.isStopped = false;
			agent.SetDestination (target.position);

			if (agent.velocity.magnitude > 0.1f)
			{
				animator.SetBool ("moving", true);
			}
			else
			{
				animator.SetBool ("moving", false);

			}
		}else
		{
			agent.isStopped = true;
			animator.SetBool ("moving", false);

		}*/

	}

	private GameObject GetNearetBall(Collider[] balls){
		GameObject ball = null;
		float minDistance = float.MaxValue;

		foreach (Collider col  in balls) {
			GameObject b = col.gameObject;
			float dist = Vector3.Distance (transform.position, b.transform.position);
			if (dist< minDistance) {
				ball = b;
				minDistance = dist;
			}
		}
		return ball;	
	}


	private void sumarMarcador(){
		//target = col.transform;
		audioSource.Play();

		switch (target.gameObject.name) {
		case "BolitaRed":
			marcadorRed.AddScore ();
			break;
		case "BolitaBlue":
			marcadorBlue.AddScore ();
			break;
		case "BolitaYellow":
			marcadorYellow.AddScore ();
			break;
		case "BolitaGreen":
			marcadorGreen.AddScore ();
			break;
		}

		//Destroy (col.gameObject);	
		Debug.Log ( "Destroy ball");
	}

	void OnCollisionEnter(Collision col){
		animator.SetTrigger ("Win");
	}


	public void DestroyTarget()
	{
		if (target != null)
		{
			sumarMarcador ();
			Destroy (target.gameObject);
		}
	}

	public void Activate(){
		active = true;
	}
}
