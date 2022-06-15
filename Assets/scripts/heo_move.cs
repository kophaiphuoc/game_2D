using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heo_move : MonoBehaviour
{
    public Transform petplayer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.follow();
    }
    void follow()
    {
        Vector3 distance = this.petplayer.position - transform.position;
        if (Input.GetKey(KeyCode.RightArrow) && distance.magnitude >= 4)
        {
            Vector3 targetpoint = this.petplayer.position - distance.normalized * 3;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetpoint, 20 * Time.deltaTime);
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        else if (Input.GetKey(KeyCode.LeftArrow) && distance.magnitude >= 0.65f)
        {
            Vector3 targetpoint = this.petplayer.position - distance.normalized * 2;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetpoint, 15 * Time.deltaTime);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
}
