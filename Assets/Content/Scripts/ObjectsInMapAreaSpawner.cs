using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsInMapAreaSpawner : MonoBehaviour
{
    [Header("DON'T CONSIDER BORDERS")]
    [SerializeField] private int numMaxObjectsOnAreaZ; //11
    [SerializeField] private int numMaxObjectsOnAreaX; //24

    [Header("")]
    [SerializeField] private float offsetNextObjectPosition; //30.65
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private Transform objectsContainer;

    private Vector3 startObjectsSpawnerLocalPosition;
    private bool[,] instantiateObject;

    // Start is called before the first frame update
    void Start()
    {
        instantiateObject = new bool[numMaxObjectsOnAreaX, numMaxObjectsOnAreaZ];
        startObjectsSpawnerLocalPosition = objectToSpawn.transform.localPosition;

        for (int z = 0; z < numMaxObjectsOnAreaZ; z++)
        {
            for (int x = 0; x < numMaxObjectsOnAreaX; x++)
            {
                instantiateObject[x, z] = true;
            }
        }

        //removes obstacles next to borders (minimal area to play)
        for (int z = 0; z < numMaxObjectsOnAreaZ; z++)
        {
            instantiateObject[0, z] = false;
            instantiateObject[numMaxObjectsOnAreaX - 1, z] = false;
        }

        for (int x = 0; x < numMaxObjectsOnAreaX; x++)
        {
            instantiateObject[x, 0] = false;
            instantiateObject[x, numMaxObjectsOnAreaZ - 1] = false;
        }
        //end removes obstacles next to borders (minimal area to play)

        for (int z = 0; z < numMaxObjectsOnAreaZ; z += 2)
        {
            for (int x = 0; x < numMaxObjectsOnAreaX; x++)
            {
                instantiateObject[x, z] = false;
            }
        }

        for (int z = 0; z < numMaxObjectsOnAreaZ; z++)
        {
            instantiateObject[2, z] = false;
            instantiateObject[6, z] = false;
            instantiateObject[9, z] = false;
        }

        GenerateObjects();
    }

    public void GenerateObjects()
    {
        Vector3 objectLocalPosition = startObjectsSpawnerLocalPosition;

        for (int z = 0; z < numMaxObjectsOnAreaZ; z++)
        {
            for (int x = 0; x < numMaxObjectsOnAreaX; x++)
            {
                if (instantiateObject[x, z])
                {
                    GameObject objectSpawned = Instantiate(objectToSpawn, objectsContainer);
                    objectSpawned.transform.localPosition = objectLocalPosition;
                }

                objectLocalPosition.x += offsetNextObjectPosition;
            }

            objectLocalPosition.z += offsetNextObjectPosition;
            objectLocalPosition.x = startObjectsSpawnerLocalPosition.x;
        }
    }
}
