using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("hub");
    }
    public void Credits()
    {
        SceneManager.LoadScene("credits");
    }
    public void Back()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
