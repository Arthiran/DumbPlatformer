using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsBoundsScript : MonoBehaviour
{

    private Collider colliderBounds;
    private int randomInt;
    public GameObject cloudPrefab1;
    public GameObject cloudPrefab2;
    public GameObject cloudPrefab3;
    public GameObject cloudPrefab4;
    public GameObject cloudPrefab5;
    // Start is called before the first frame update
    void Start()
    {
        colliderBounds = GetComponent<BoxCollider>();

        for (int i = 0; i <= 500; i++)
        {
            randomInt = Random.Range(1, 6);
            GameObject cloud = cloudPrefab1;
            if (randomInt == 1)
            {
                cloud = Instantiate(cloudPrefab1, RandomPointInBounds(colliderBounds.bounds), Quaternion.identity);
            }
            else if (randomInt == 2)
            {
                cloud = Instantiate(cloudPrefab2, RandomPointInBounds(colliderBounds.bounds), Quaternion.identity);
            }
            else if (randomInt == 3)
            {
                cloud = Instantiate(cloudPrefab3, RandomPointInBounds(colliderBounds.bounds), Quaternion.identity);
            }
            else if (randomInt == 4)
            {
                cloud = Instantiate(cloudPrefab4, RandomPointInBounds(colliderBounds.bounds), Quaternion.identity);
            }
            else if (randomInt == 5)
            {
                cloud = Instantiate(cloudPrefab5, RandomPointInBounds(colliderBounds.bounds), Quaternion.identity);
            }
            else
            {
                cloud = Instantiate(cloudPrefab1, RandomPointInBounds(colliderBounds.bounds), Quaternion.identity);
            }
            cloud.transform.parent = transform;
        }
    }

    public static Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
