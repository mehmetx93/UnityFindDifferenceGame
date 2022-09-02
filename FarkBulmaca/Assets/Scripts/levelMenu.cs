using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelMenu : MonoBehaviour
{
    public void PlayBigLevel()
    {

        if (PlayerPrefs.HasKey("openLevels"))
        {
            float levelno = PlayerPrefs.GetInt("openLevels");

            switch (Mathf.CeilToInt(levelno / 8))
            {
                case 1: SceneManager.LoadScene("LevelsSceneP1"); break;
                case 2: SceneManager.LoadScene("LevelsSceneP2"); break;
                case 3: SceneManager.LoadScene("LevelsSceneP3"); break;
                default: SceneManager.LoadScene("LevelsSceneP1"); break;
            }
        }
        else
        { SceneManager.LoadScene("LevelsSceneP1"); }
    }
    public void loadLevel()
    {
        levelChange.levelID = System.Convert.ToInt32(this.name.Split('-')[1]) - 1;
        SceneManager.LoadScene("Levels");

    }

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void upLevel()
    {
        levelChange.levelID = System.Convert.ToInt32(this.name.Split('-')[1]);
        SceneManager.LoadScene("Levels");

    }
}
