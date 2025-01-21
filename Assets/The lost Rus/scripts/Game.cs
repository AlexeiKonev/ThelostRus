using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
// Make the enum public and outside the Game class for broader accessibility
public enum RusHeroStates
{
    idle,
    specskill
}

public class Game : MonoBehaviour
{
    // Object of the rus hero
    private RusHero _rusHero;
    private EnemySpawnManager _enemySpawnManager;

    [SerializeField]
    EnemySpawnView enemyView;
    [SerializeField]
    private HeroProvider heroProvider;

    int countEnemy = 0;
    // Start is called before the first frame update
    private void Start()
    {
        // _rusHero automatically sets state to idle in the constructor of the RusHero class.
        _rusHero = new RusHero();

        heroProvider.StartHero();

        _enemySpawnManager = new EnemySpawnManager();

        enemyView.EnemySpawnStart();
     
    }

    // Update is called once per frame
    private void Update()
    {
        //update for   hero
        heroProvider.HeroUpdate();

        ChangeHeroState();
        if (countEnemy == 0)
        {

            StartCoroutine(SpawnDelay());

        }
        IEnumerator SpawnDelay()
        {
            int index = _enemySpawnManager.GetSpawnIndex();

            enemyView.SpawnEnemy(index);
            countEnemy = 1;
            yield return new WaitForSeconds(3f);
            countEnemy = 0;
        }
    }
    private void ChangeHeroState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_rusHero.state == RusHeroStates.idle)
            {
                _rusHero.state = RusHeroStates.specskill;
                heroProvider.WeaponOn();
                Debug.Log("specskill is active");
            }

            else if (_rusHero.state == RusHeroStates.specskill)
            {
                _rusHero.state = RusHeroStates.idle;
                heroProvider.WeaponOff();
                Debug.Log("specskill not active");
            }
        }
    }
}

public class RusHero
{
    public RusHeroStates state;

    public RusHero()
    {
        state = RusHeroStates.idle;
    }
}

public class EnemySpawnManager
{
    public int indexSpawn ;

    public int GetSpawnIndex()
    {
        return indexSpawn = Random.Range(0, 3);

    }
}

