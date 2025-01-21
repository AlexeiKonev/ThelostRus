using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnView : MonoBehaviour
{
  [SerializeField] Transform tr1;
  [SerializeField] Transform tr2;
  [SerializeField] Transform tr3;
  [SerializeField] GameObject enemyPrefab;
  public void EnemySpawnStart()
  {
    tr1 = transform.GetChild(0);

    tr2 = transform.GetChild(1);

    tr3 = transform.GetChild(2);
  }

  // Update is called once per frame
  public void EnemySpawnUpdate()
  {

  }
  public void SpawnEnemy(int index)
  {
    if (index == 0) { GameObject.Instantiate(enemyPrefab, tr1); }

    else if (index == 1) { GameObject.Instantiate(enemyPrefab, tr2); }

    else if (index == 2) { GameObject.Instantiate(enemyPrefab, tr3); }


    Debug.Log($"enemy spawed in {index}");

  }
}
