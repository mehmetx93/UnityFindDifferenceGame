using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLocation : MonoBehaviour
{
    public GameObject targetArea;
    public int sensibility;
    static public int objectSize = 40;
    static public bool tryCheck = false;
    public GameObject nextButton;


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2(objectSize, objectSize);

    }

    private void CheckLocation()
    {






        if (Mathf.Abs(this.transform.position.x - targetArea.transform.position.x) < sensibility && Mathf.Abs(this.transform.position.y - targetArea.transform.position.y) < sensibility)
        {
            this.GetComponent<Image>().color = Color.green;


            nextButton.SetActive(true);



            int openLevels = PlayerPrefs.GetInt("openLevels");
            if (levelChange.levelID + 1 >= openLevels)
            {


                PlayerPrefs.SetInt("openLevels", ++openLevels);
                levelLock.tryOpenLevels = true;

            }

        }
        else
        {
            this.GetComponent<Image>().color = Color.red;



        }

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            print("locations[" + levelChange.levelID + "] = new Vector2(" + Mathf.Round(this.transform.localPosition.x) + ", " + Mathf.Round(this.transform.localPosition.y) + ");");


        }
        if (tryCheck)
        {
            CheckLocation();
            tryCheck = false;
        }
    }
}
