using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour
{
	public float distanceAway = 7;
	public float distanceUp = 2;
	public float smooth = 1.25f;
	[HideInInspector] public Transform follow; // set dynamically by GameManager

	private Vector3 targetPosition;

	void Start ()
	{
	}

	void Update () {}

	void LateUpdate()
	{
		if (!follow) return;

		targetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;
		Debug.DrawRay (follow.position, Vector3.up * distanceUp, Color.red);
		Debug.DrawRay (follow.position, -1f * follow.forward * distanceAway, Color.blue);
		Debug.DrawLine(follow.position, targetPosition, Color.magenta);
		transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);
		transform.LookAt(follow);
	}
}
