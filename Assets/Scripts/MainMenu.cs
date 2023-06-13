using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button[] mainMenu;
    [SerializeField] Button[] menuBtn;

    [SerializeField] GameObject menuWindow;
    [SerializeField] Button exitWindow;

    private void Start()
    {
        //Add Listerner to the Mainmenu
        foreach (var btn in mainMenu)
        {
            btn.onClick.AddListener(() => MenuMenuBtn(btn.tag));
        }
        //Add Listerner to the MenuList
        foreach (var btn in menuBtn)
        {
            btn.onClick.AddListener(() => MenuMenuBtn(btn.tag));
        }

        //Add Listerner to the Exit MenuList
        exitWindow.onClick.AddListener(() => ExitWindow());
    }

    public void MenuMenuBtn(string tag)
    {
        try
        {
            //Enable menu win
            menuWindow.SetActive(true);

            //Change color on selection
            foreach (var item in menuBtn)
            {
                if (item.tag == tag)
                {
                    item.GetComponent<Image>().color = Color.white;
                    item.transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    item.GetComponent<Image>().color = Color.gray;
                    item.transform.GetChild(0).gameObject.SetActive(false);
                }
            }
        }
        catch (System.Exception)
        {
            //Error
        }
        
    }

    public void ExitWindow()
    {
        menuWindow.SetActive(false);
    }
}
