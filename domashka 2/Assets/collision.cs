using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collision : MonoBehaviour
{
    public TextMeshProUGUI schetchik;
    private int health = 3;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "pol")
        {
            if (health == 0)
            {

                schetchik.text = "Конец";
            }
            else
            {
                schetchik.text = "Cчетчик: " + (--health);
            }

        }



    }
}