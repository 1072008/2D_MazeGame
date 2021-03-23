using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class End : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider coin;
    public Text messa;
    public Slider blood;
    public GameObject main;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(coin.value==5&&blood.value!=0)
        {
            messa.text = "Win!";
            Time.timeScale = 0f;
            Destroy(main.gameObject);

        }
        else
        {
            messa.text = "Lose!";
            Time.timeScale = 0f;
            Destroy(main.gameObject);
        }
    }
}
