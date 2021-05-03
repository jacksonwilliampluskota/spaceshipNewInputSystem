using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadSinglePlayerGame()
    {
        print("Load single game player....");
        SceneManager.LoadScene("Single_player");
    }

    public void LoadCoOpGame()
    {
        print("Load Coop game player....");
        SceneManager.LoadScene("Co-op_mode");
    }

    public void LoadCreditsGame()
    {
        print("Load credits game player....");
        SceneManager.LoadScene("Credits");
    }
}
