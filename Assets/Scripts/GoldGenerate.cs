using UnityEngine;
using System.Collections;

public class GoldGenerate : MonoBehaviour {

	//接受需要加载的模型
	public GameObject enemyship;
	//定义生成的个数
	public int enemyCount;
	//定义一个时间，让物体在一段时间后开始加载
	public float WaitTime;
	//生成下一个物体的时间间隔
	private float NextTime;

	public GameObject mc;
	// Use this for initialization
	void Start () {
		NextTime = 5;
		StartCoroutine(spawnWaves());
		mc = GameObject.FindGameObjectWithTag("Player");
	}

	IEnumerator spawnWaves()
	{
		yield return new WaitForSeconds(WaitTime);

		while (true)
		{
			for(int i=0;i<enemyCount;i++) 
			{
				//随机位置
				Vector3 shipPosition = new Vector3(5,
					Random.Range((mc.transform.position.y+20),(mc.transform.position.y+30)), 
					Random.Range((mc.transform.position.z), (mc.transform.position.z+2)));
				//随机角度
				Quaternion shipRotation = Quaternion.Euler(Random.Range(0,1), Random.Range(0, 1), Random.Range(0, 1));
				//生成物体
				Instantiate(enemyship, shipPosition, shipRotation);
				//生成物体的时间间隔
				yield return new WaitForSeconds(NextTime);
			}
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
