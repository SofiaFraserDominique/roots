using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour


{
    [SerializeField] private Transform player;
	private Vector3 distCompensar;

	void Start()
	{
		distCompensar = transform.position - player.position;
	}

		void FixedUpdate()
	{
		transform.position = player.position + distCompensar;
	}
}
