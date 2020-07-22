using UnityEngine;

public class Pause : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void OnPause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
