using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuevitoProject : MonoBehaviour
{
    public GameObject prefab;
    public GameObject EggSpawnPoint;
    int tamaño = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(prefab);
            clon.transform.position = EggSpawnPoint.transform.position;
            prefab.transform.localScale += new Vector3 (tamaño, tamaño, tamaño);
        }
    }
}
