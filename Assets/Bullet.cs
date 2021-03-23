using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float BulletSpeed = 8;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.parent = null;
        this.transform.position += new Vector3(0.1f, 0.005f, 0);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Idle (32x32)_0")
            Destroy(this.gameObject);
    }
}
