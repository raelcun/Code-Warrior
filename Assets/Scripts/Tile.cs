using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
	public Vector2 gridPosition = Vector2.zero;

	void Start () {}

	void Update () {}

	void OnMouseEnter()
	{
		Debug.Log(string.Format("({0},{1})", gridPosition.x, gridPosition.y));
	}
}