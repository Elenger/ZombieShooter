using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private bool firstBoot = true;
    public void LoadScene()
    {
        if (firstBoot) firstBoot = false;
        else SceneManager.LoadScene("Arena", LoadSceneMode.Single);
    }
}
