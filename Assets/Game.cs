using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public void GotoGame()
    {

        SceneManager.LoadScene(1);



    }
    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
