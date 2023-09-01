using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int prevScene = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPressEasyBtn()
    {
        prevScene = 1;
        SceneManager.LoadScene("Level 1");
              
    }
    public void OnPressMediumBtn()
    {
        prevScene = 2;
        SceneManager.LoadScene("Level 2");
        
        
    }
    public void OnPressHardBtn()
    {
        prevScene = 3;
        SceneManager.LoadScene("Level 3");
        
        
    }
    public void OnPressHomeBtn()
    {
        ArrowController.lives = 3;
        ArrowController.score = 0;
        SceneManager.LoadScene("Level Manager");
    }
    public  void OnPressQuitBtn()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void OnPressRestartBtn()
    {
        ArrowController.lives = 3;
        ArrowController.score = 0;
        if (prevScene == 1)
        {
            
            SceneManager.LoadScene("Level 1");
        }
       else if(prevScene == 2)
        {
            SceneManager.LoadScene("Level 2");
        }
        else if (prevScene == 3)
        {
            SceneManager.LoadScene("Level 3");
        }
        else
        {
            SceneManager.LoadScene("Level Manager");
        }
    }
}
