using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SelectEscena()
    {
        SceneManager.LoadScene(GameConstants.NameScenes.esena_uno);
    }

    public void Exit()
    {

    }
}
