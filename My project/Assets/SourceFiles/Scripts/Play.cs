using UnityEngine;
using UnityEngine.SceneManagement;

class Menu : MonoBehaviour
{
    public int Scene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(Scene);
    }
}