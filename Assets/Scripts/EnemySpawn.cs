using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject rabbit;

    [SerializeField]
    GameObject fox;

    public float spawnTimer;
    public int rng;

    void Start()
    {
        spawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer > 10)
        {
            spawnTimer = 0;

            rng = Random.Range(1, 3);
            if (rng == 1)
            {
                Instantiate(rabbit, new Vector3(11, 6, 0), transform.rotation);
                Instantiate(fox, new Vector3(-11, 6, 0), transform.rotation);
            }
            else
            {
                Instantiate(fox, new Vector3(11, 6, 0), transform.rotation);
                Instantiate(rabbit, new Vector3(-11, 6, 0), transform.rotation);
            }
        }
    }
}
