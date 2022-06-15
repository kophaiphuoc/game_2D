using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_move : MonoBehaviour
{
    public Animator anim;
    bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("idel", false);
        anim.SetBool("running", false);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
            anim.SetBool("idel", true);
            anim.Play("running");
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
         if (Input.GetKey(KeyCode.LeftArrow))
        {
            isRight = false;
            anim.SetBool("idel", true);
            anim.Play("running");
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
         if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("idel", true);
            anim.Play("running");
            transform.Translate(0, Time.deltaTime * 5, 0);
        }


        ///////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.Q) && isRight == true)
        {         
            anim.SetBool("running", true);
            anim.Play("skill_1");
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        if (Input.GetKey(KeyCode.Q) && isRight == false)
        {
            anim.SetBool("running", true);
            anim.Play("skill_1");
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }
        /////////////////////////////////////////
         if (Input.GetKey(KeyCode.W) && isRight == true)
        {
            anim.SetBool("running", true);
            anim.Play("skill_2");
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Input.GetKey(KeyCode.W) && isRight == false)
        {
            anim.SetBool("running", true);
            anim.Play("skill_2");
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        /////////////////////////////////////
        if (Input.GetKey(KeyCode.E) && isRight == true)
        {
            anim.SetBool("running", true);
            anim.Play("skill_3");
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Input.GetKey(KeyCode.E) && isRight == false)
        {
            anim.SetBool("running", true);
            anim.Play("skill_3");
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        /////////////////////////////////////////
        if (Input.GetKey(KeyCode.R)&& isRight == true)
        {
            anim.SetBool("running", true);
            anim.Play("skill_4");
            transform.Translate(Time.deltaTime * 5, Time.deltaTime * 5, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Input.GetKey(KeyCode.R)&& isRight == false)
        {
            anim.SetBool("running", true);
            anim.Play("skill_4");
            transform.Translate(-Time.deltaTime * 5, Time.deltaTime * 5, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

    }
}
