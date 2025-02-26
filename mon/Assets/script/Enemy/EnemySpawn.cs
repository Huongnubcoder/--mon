using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public bool CanSpawn = true;
    public GameObject[] SpawnPrefab;
    public float Radius = 3f;
    public float EnemyCount = 0;
    public float SpawnRate = 1f;
    void Start()
    {
        StartCoroutine (spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator spawner() { 
        WaitForSeconds Wait = new WaitForSeconds(SpawnRate);

        while (CanSpawn)
        {
            
            
                Vector3 rand = Random.insideUnitCircle * Radius;
                Vector3 SpawnPosition = new Vector3(rand.x + transform.position.x, rand.y + transform.position.y, transform.position.z);
                if (Physics2D.OverlapCircle(SpawnPosition,0.5f) == null) { 
                    int EnemyType = Random.Range(0, SpawnPrefab.Length );
                    GameObject Enemy = SpawnPrefab[EnemyType];
                    Instantiate(Enemy, SpawnPosition, Quaternion.identity);
                    EnemyCount++;
                    
                }

            
            if (EnemyCount >= 5)
            {
                CanSpawn = false;
                break;
            }  
            yield return Wait;
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,Radius);
    }
}
