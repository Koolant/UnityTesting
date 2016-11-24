using UnityEngine;
using System.Collections;

public class WallPassThrough : MonoBehaviour {

	private Collider col;

	void Awake () 
	{
		col = GetComponent<Collider> ();
	}
		
	void Update () 
	{
		col.isTrigger = Input.GetButton ("Fire3");
	}
}
