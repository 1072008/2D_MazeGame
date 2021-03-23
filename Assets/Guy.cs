using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guy : MonoBehaviour
{
    // Start is called before the first frame update
    enum GUY_state {treasure,flee,hide };
    GUY_state state = GUY_state.treasure;
    /*public GameObject _trea;
    public GameObject _mon;
    public float _speed = 3.0f;*/
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.parent = null;
        this.transform.position += new Vector3(0, -0.001f, 0);
        /*switch(state)
        {
            case GUY_state.treasure:
                gathertreasure();
                if (seeman()) state = GUY_state.flee;
                break;
            case GUY_state.flee:
                Flee();
                if (manfar()) state = GUY_state.treasure;
                if (manclose()) state = GUY_state.hide;
                break;
            case GUY_state.hide:
                Hide();
                if (manfar()) state = GUY_state.treasure;
                break;

        }*/
    }
    /*void gathertreasure()
    {
        Vector2 dir = _trea.transform.position - transform.position;
        dir.Normalize();
        transform.Translate(dir * Time.deltaTime * _speed);
    }
    bool seeman()
    {
    float dis=Vector2.Distance(transform.position)
    }
    bool manfar()
    {

    }
    bool manclose()
    {

    }
    void Flee()
    {
        Vector2 dir = transform.position - _mon.transform.position;
        dir.Normalize();
        transform.Translate(dir*Time*deltaTime*_speed);
    }
    void Hide()
    {

    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ice Particle" || collision.gameObject.name == "Ice Particle(Clone)")
        {
            Destroy(this.gameObject);
        }
        
    }
}
