using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void StartDataBase()
    {
        SceneManager.LoadScene("main");
    }
    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }
}
