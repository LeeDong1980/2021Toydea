using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public List<GameObject> itemPrefabs = new List<GameObject>();
    public float interval;
    public float itemSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateItem(GameObject prefab)
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
