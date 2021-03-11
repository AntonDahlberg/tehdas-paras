using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap1 : MonoBehaviour
{
	public Transform player;
	public GameObject endgame;
	public GameObject ahaa;

	void LateUpdate()
	{
		Vector3 newPosition = player.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;

		transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
	}
	void Update()
	{
		if (Input.GetKey(KeyCode.N))
		{
			ahaa.gameObject.SetActive(false);
			endgame.gameObject.SetActive(true);

		}


	}

}
