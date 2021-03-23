using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int i = Random.Range(3, 7);
        for(int j=1;j<=i;j++)
        {
            Instantiate(Bullet, transform.position, new Quaternion(0, 0, 0, 0));
        }
        
    }
}
