using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSaver : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject menuList;
    [SerializeField] int screentimeout = 10;
    // Start is called before the first frame update
    void Start()
    {
        //Start countdown
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        //get mouse pos
        var mousePos = Input.mousePosition;

        //wait for sec
        yield return new WaitForSeconds(screentimeout);

        //check if prev.mouse pos == cur.mouse pos
        //if so, disable mainmenu. if not, start timer again
        if (Input.mousePosition == mousePos)
        {
            mainMenu.SetActive(false);
            menuList.SetActive(false);
        }
        else
        {
            StartCoroutine(Countdown());
        }

       
    }

    //Show main menu on click
    public void ShowMenu()
    {
        mainMenu.SetActive(true);
        StartCoroutine(Countdown());
    }
}
