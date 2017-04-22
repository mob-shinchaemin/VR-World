using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed = 3f;
	public float rotateSpeed = 30f;
	Animation p_anim;

	// Use this for initialization
	void Start () {
		p_anim = GetComponent<Animation> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, speed * Time.deltaTime);
			p_anim.CrossFade ("walk");
		}else if(Input.GetKey (KeyCode.S)){
			transform.Translate (0, 0, -speed * Time.deltaTime);
			p_anim.CrossFade ("walk");			
		}else if(Input.GetKey(KeyCode.A)){
			transform.Rotate (0,-rotateSpeed*Time.deltaTime,0);
			p_anim.CrossFade ("walk");
		}else if(Input.GetKey(KeyCode.D)){
			transform.Rotate (0,rotateSpeed*Time.deltaTime,0);
			p_anim.CrossFade ("walk");
		}else {
			p_anim.CrossFade ("idle");
		}
	}
}
