using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadSceneAsync("MiniGame");
    }

}
