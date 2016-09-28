using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Animator))]
public class UCController : MonoBehaviour
{

	private Animator animator;
	private int doWalkId;

	private const float speed = 3.5f;
	private bool walk = false;
	private Vector3 move = new Vector3 (1.0f, 0.0f, 0.0f);

	// Use this for initialization
	void Start ()
	{
		animator = GetComponent<Animator> ();
		doWalkId = Animator.StringToHash ("DoWalk");
		animator.SetBool (doWalkId, true);
	}

	// Update is called once per frame
	void Update ()
	{
		/*
		if (Input.GetKey (KeyCode.UpArrow)) {
			animator.SetBool (doWalkId, true);
			walk = true;
		} else {
			animator.SetBool (doWalkId, false);
			walk = false;
		}
		*/
		//if (walk) {	
			transform.position += move * speed * Time.deltaTime;
		//}
	}
}
