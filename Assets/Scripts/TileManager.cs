using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {
	public GameObject floorTile;
	
	private float respawnPeriod = 15.0f;
	private float lastRespawn;
	
	// Use this for initialization
	void Start () {
		spawnNewTile();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > lastRespawn + respawnPeriod) {
			spawnNewTile();
		}
	}
	
	void spawnNewTile() {
		GameObject floorTileClone =  (GameObject) Instantiate(floorTile);
		lastRespawn = Time.time;
	}
}
