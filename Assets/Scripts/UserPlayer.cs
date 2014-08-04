using UnityEngine;
using System.Collections;

public class UserPlayer : Player
{
	void Start ()
	{
		base.Start ();
	}

	void Update ()
	{
		base.Update ();

		if (Input.GetKeyDown (KeyCode.W))
				base.moveForward ();
		if (Input.GetKeyDown (KeyCode.S))
				base.moveBackward ();
		if (Input.GetKeyDown (KeyCode.A))
				base.strafeLeft ();
		if (Input.GetKeyDown (KeyCode.D))
				base.strafeRight ();
		if (Input.GetKeyDown (KeyCode.Q))
				base.turnLeft ();
		if (Input.GetKeyDown (KeyCode.E))
				base.turnRight ();
	}
}