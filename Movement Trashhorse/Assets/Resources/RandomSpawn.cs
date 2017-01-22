using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject TrashPrefab;
    public GameObject EnemyPrefab;

	public float trashSpawnTimerMax;
	public float enemySpawnTimerMax;
	public int numer;
	public int denom;

	private float trashSpawnTimer;
	private float enemySpawnTimer;
	private float powerSpawnTimer;

	public int maxenemy;
	public int maxtrash;
	public int maxpower;
	private int enemyno;
	private int trashno;
	private int powerno;

    public Vector3 Center;
    public Vector3 size;

	// Use this for initialization
	void Start () {

        size = new Vector3(10, 5, 0);

		trashSpawnTimer = trashSpawnTimerMax;
		enemySpawnTimer = enemySpawnTimerMax;
		powerSpawnTimer = 1f;



		enemyno = 0;
		trashno = 0;
		powerno = 0;
	}
	
	// Update is called once per frame
	void Update () {

        trashSpawnTimer -= Time.deltaTime;
        enemySpawnTimer -= Time.deltaTime;
		powerSpawnTimer -= Time.deltaTime;

        SpawnTrash();
        SpawnEnemy();
		SpawnPower ();

    }

	public void SpawnPower (){

		if(powerSpawnTimer < 0){
			
		if (powerno < maxpower && Random.Range (1, denom) <= numer) {
			Vector3 pos = Center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
				GameObject p = Instantiate (Resources.Load ("Bubbler"),pos,Quaternion.identity) as GameObject;

			powerno++;
			p.GetComponent<Bubbler> ().destroyed += powerDown;
			}
			powerSpawnTimer = 1f;
		}
	}

    public void SpawnTrash()
    {
        Vector3 pos = Center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        if(trashSpawnTimer < 0)
        {
			if (trashno < maxtrash) {
				GameObject t = Instantiate (TrashPrefab, pos, Quaternion.identity) as GameObject;
				t.GetComponent<Trash> ().destroyed += trashDown;
				trashno++;
			}
				trashSpawnTimer = trashSpawnTimerMax;

        }
    }
    public void SpawnEnemy()
    {
        Vector3 pos = Center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        if (enemySpawnTimer < 0)
        {
			if (enemyno < maxenemy) {
				GameObject e = Instantiate (EnemyPrefab, pos, Quaternion.identity) as GameObject;
            

				enemyno++;
				e.GetComponent<Gun> ().destroyed += enemyDown;
			}

			enemySpawnTimer  = enemySpawnTimerMax;


        }
    }

	private void powerDown(){
		powerno--;
	}

	private void trashDown (){
		trashno--;
	}

	private void enemyDown(){
		enemyno--;
	}
}
