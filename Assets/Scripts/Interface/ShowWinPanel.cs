using System.Collections;
using UnityEngine;

public class ShowWinPanel : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;

    public void ShowWin()
    {
        StartCoroutine("StartTimer");
    }

    IEnumerator StartTimer()
    {
        for (;;)
        {
            yield return new WaitForSeconds(3);
            _winPanel.SetActive(true);
        }
    } 
}
