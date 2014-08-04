using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	private Vector3 facing = new Vector3(0, 0, 1);
	
	protected void Start ()
	{
	}
	
	protected void Update ()
	{
	}

	public void moveForward()
	{
		transform.position += facing;
	}

	public void moveBackward()
	{
		transform.position -= facing;
	}

	public void strafeLeft()
	{
		transform.position -= Quaternion.Euler(0, 90, 0) * facing;
	}

	public void strafeRight()
	{
		transform.position += Quaternion.Euler(0, 90, 0) * facing;
	}

	public void turnLeft()
	{
		facing = Quaternion.Euler(0, -90, 0) * facing;
		transform.rotation = Quaternion.Euler(0, -90, 0) * transform.rotation;
	}

	public void turnRight()
	{
		facing = Quaternion.Euler(0, 90, 0) * facing;
		transform.rotation = Quaternion.Euler(0, 90, 0) * transform.rotation;
	}
}