using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - player.transform.position; //카메라 좌표 - 플레이어 좌표
	}

	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
}