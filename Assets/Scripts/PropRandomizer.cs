// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PropRandomizer : MonoBehaviour
// {
//     public List<GameObject> propSpawnPoints;
//     public List<GameObject> propPrefabs;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     void SpawnProps()
//     {
//         foreach (GameObject sp in propSpawnPoints)
//         {
//             int rand = PropRandomizer.Range(0. propPrefabs.Count);
//             Instantiate(propPrefabs[rand], sp.transform.position, Quarternion.identity);
//         }
//     }
// }
