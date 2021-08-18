using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPath : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            items.Add(transform.GetChild(i).gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = transform.position + new Vector3(0f, 0f, -Time.deltaTime * speed);
    }
}
