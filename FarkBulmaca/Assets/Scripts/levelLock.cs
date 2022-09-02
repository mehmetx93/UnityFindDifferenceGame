using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelLock : MonoBehaviour
{
    static public bool tryOpenLevels;
    public Sprite lockSprite;
    public Sprite normalSprite;
    GameObject[] buttons;
    // Start is called before the first frame update
    void Start()
    {
       
        if (!PlayerPrefs.HasKey("openLevels"))
        { PlayerPrefs.SetInt("openLevels", 1); }

        openLevels();
      
    }
    public void openLevels()
    {
        foreach (Button btn in FindObjectsOfType<Button>())
        {

            if (btn.name.Contains("Button"))
            {

              
                int openLevelsnumber = PlayerPrefs.GetInt("openLevels");

                
                if (System.Convert.ToInt32(btn.name.Split('-')[1]) > openLevelsnumber)
                {
                    
                    btn.image.sprite = lockSprite;
                    btn.interactable = false;
                }
                else
                {
                   
                    btn.image.sprite = normalSprite;
                    btn.interactable = true;
                }
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (tryOpenLevels)
        {
            openLevels();
            tryOpenLevels = false;
        }
    }

}
