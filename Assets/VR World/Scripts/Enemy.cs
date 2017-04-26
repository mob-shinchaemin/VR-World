using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float m_speed = 1.5f;
	public float m_rotate = Random.Range(30.0f, -30.0f);
	public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, m_speed * Time.deltaTime);
		transform.Rotate (0, m_rotate * Time.deltaTime, 0);
	}
}
