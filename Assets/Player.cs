using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider blood;
    public GameObject Bullet;
    public Text time;
    public Text text;
    int i = 60;
    int f = 1;
    void Start()
    {
        blood.value = 10;
        time.text = i.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        fight();
        f++;
        if(f==120)
        {
            f = 0;
            i -= 1;
        }
        time.text = i.ToString();
        if(i==0)
        {
            Time.timeScale = 0f;
            text.text = "Time Up!";
        }
    }
    void move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.08f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.08f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.08f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.08f, 0);
        }
    }
    void fight()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position, new Quaternion(0, 0, 0, 0));
        }
        //if(transform.position.x==&&transform.position.y==)
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bad" || collision.gameObject.name == "Bad(Clone)")
        {
            blood.value -= 1;
        }
    }
}
