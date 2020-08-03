using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private Pause _pause;
    private static bool _notFirstBoot = false;

    public void LoadScene()
    {
        if (_notFirstBoot)
        {
            SceneManager.LoadScene("Arena", LoadSceneMode.Single);
        }
        else
        {
            _notFirstBoot = true;
        }
    }

    private void Start()
    {
        if (_notFirstBoot)
        {
            _mainMenu.SetActive(false);
            _pause.OnPause();
        }
    }
}
