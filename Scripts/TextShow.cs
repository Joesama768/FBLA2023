using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextShow : MonoBehaviour
{
    public GameObject text;

    void Start()
    {
        text.SetActive(false); // makes the text not show initally;

    }


    // on collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Make your text object appear on screen
            text.SetActive(true);

        }
    }


    //when exit collision
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Make your text object disapearr on the screen
            text.SetActive(false);


        }
    }


}
