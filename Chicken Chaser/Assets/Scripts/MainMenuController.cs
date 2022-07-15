using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        string clickedObj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        int charIndex;
        switch(clickedObj)
        {
            case "Select P1":
                charIndex = 0;
                break;
            case "Select P2":
                charIndex = 1;
                break;
            default:
                charIndex = 0;
                break;
        }
        
        GameManger.instance.CharIndex = charIndex;
        SceneManager.LoadScene("Gameplay");
    }
}
