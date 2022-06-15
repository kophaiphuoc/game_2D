using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_map_Y : MonoBehaviour
{
    public bool map_y;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (map_y == true)
        {
            transform.Translate(0, -Time.deltaTime*5, 0);
        }
        else
        {
            transform.Translate(0, Time.deltaTime * 5, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tren")
        {
            map_y = true;
        }
        if (collision.gameObject.tag == "duoi")
        {
            map_y = false;
        }
    }
}
