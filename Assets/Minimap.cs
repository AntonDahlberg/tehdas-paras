using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{

	public Transform player;
	public GameObject endgame;
	public GameObject ahaa;

	void LateUpdate()
	{
		Vector3 newPosition = player.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;
		



	}
	void Update()
    {
		if (Input.GetKey(KeyCode.M))
        {
			ahaa.gameObject.SetActive(true);
			endgame.gameObject.SetActive(false);
			

		}


	}

}
