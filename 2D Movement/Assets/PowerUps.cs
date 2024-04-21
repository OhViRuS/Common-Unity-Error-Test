using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject[] powerups;
    void Start()
    {
		StartCoroutine(SpawnPowerup());
	}

    IEnumerator SpawnPowerup()
    {
        while (true)
        {
			yield return new WaitForSeconds(2);

			if (powerups.Length > 0)
			{
				int randomIndex = Random.Range(0, powerups.Length);
				Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
				Instantiate(powerups[randomIndex], spawnPosition, Quaternion.identity); //fixed this part because it kept giving me index out of bounds error
			}
		}
    }
}
