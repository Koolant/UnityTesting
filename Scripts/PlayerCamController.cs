using UnityEngine;
using System.Collections;

public class PlayerCamController : MonoBehaviour
{

    public Transform player;
	Vector3 diff;
    public float camSpeed = 15;
    public bool smooth = true;

    void Start()
	{
		diff = transform.position - player.position;
    }

    void FixedUpdate()
    {
		Vector3 newPos = player.position + diff;
        transform.position = Vector3.Lerp(transform.position, newPos, camSpeed * Time.deltaTime);
    }
}