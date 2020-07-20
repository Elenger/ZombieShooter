using UnityEngine;

public class CharacterDeath : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private SoundController _soundController;
    [SerializeField] private Pause _pause;
    public void Death()
    {
        _soundController.CharacterDeath_Sound();
        _losePanel.SetActive(true);
    }
}

