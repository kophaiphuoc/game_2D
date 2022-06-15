using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_monster : MonoBehaviour
   
{
    public AudioSource Sound_main;
    public AudioSource Sound_dead;
    // Start is called before the first frame update
    void Start()
    {
        Sound_main.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)

    {

        //if (collision.gameObject.tag == " tren ")
        //{
        //    Destroy(GameObject.Find("character_0000"));
        //}
        if (collision.gameObject.tag == "tren")
        {
            Sound_main.Stop();
            Sound_dead.Play();
            Destroy(collision.gameObject);
            
        }
        else {
            Debug.Log(collision.gameObject.tag);
        }
    }

}
