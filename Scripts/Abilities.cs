using UnityEngine;
using System.Collections;

public class Abilities : MonoBehaviour {

	private Collider col;

	// Use this for initialization
	void Awake () 
	{
		col = GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		col.isTrigger = Input.GetButton ("Fire3");
	}
}
