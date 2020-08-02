using UnityEngine;

public class ShowLosePanel : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;

    public void ShowLose()
    {
        _losePanel.SetActive(true);
    }
}
