using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	public GameObject TilePrefab;
	public GameObject PlayerPrefab;
	public GameObject PlayerCameraPrefab;
	public Vector2 MapSize;

	private List<List<Tile>> map;

	void Start ()
	{
		generateMap();
		generatePlayer();
	}

	void Update () {}

	private void generateMap()
	{
		map = new List<List<Tile>>();

		for (int r = 0; r < MapSize.x; r++)
		{
			List <Tile> row = new List<Tile>();
			for (int c = 0; c < MapSize.y; c++)
			{
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(r - Mathf.Floor(MapSize.x / 2), -TilePrefab.renderer.bounds.size.y / 2, c - Mathf.Floor(MapSize.y / 2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector2(r, c);
				row.Add (tile);
			}
			map.Add(row);
		}

		map[0][0].renderer.material.color = Color.blue;
		map[(int)MapSize.x-1][(int)MapSize.y-1].renderer.material.color = Color.red;
	}

	private void generatePlayer()
	{
		Player player = ((GameObject)Instantiate(PlayerPrefab, new Vector3(2,2,2), Quaternion.Euler(new Vector3(15, 0, 0)))).GetComponent<Player>();

		FollowCamera camera = ((GameObject)Instantiate(PlayerCameraPrefab, new Vector3(2,2,2), Quaternion.Euler(new Vector3(15, 0, 0)))).GetComponent<FollowCamera>();
		camera.follow = player.transform;

		player.transform.position = new Vector3(map[0][0].transform.position.x, player.renderer.bounds.size.y / 2 + 0.1f, map[0][0].transform.position.z);
	}
}