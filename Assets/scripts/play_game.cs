using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class play_game : MonoBehaviour
{
    public Text txtsocre;
    int diem = 0;
    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        txtsocre = GameObject.Find("diem").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "hi")
        {
            diem += 1;
            txtsocre.text = "X:" + diem.ToString();
            Destroy(collision.gameObject);
            Instantiate(effect, collision.gameObject.transform.position, collision.gameObject.transform.localRotation);

        }
    }
}
