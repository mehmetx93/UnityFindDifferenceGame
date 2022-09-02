using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace QuantumTek.QuantumUI
{
    /// <summary>
    /// QUI_Menu is responsible for managing all of the UI elements in a menu.
    /// </summary>
    [AddComponentMenu("Quantum Tek/Quantum UI/Menu")]
    [DisallowMultipleComponent]
    public class QUI_Menu : MonoBehaviour
    {
        public void Play(string levelName)
        {
            SceneManager.LoadScene(levelName);
        }
        public void PlayBigLevel()
        {

            if (PlayerPrefs.HasKey("openLevels"))
            {
                float levelno = PlayerPrefs.GetInt("openLevels");
                print(levelno);
                print(Mathf.CeilToInt(levelno / 8));
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
        public void Settings()
        {
            SceneManager.LoadScene("UI Elements Settings");
        }
    }

}