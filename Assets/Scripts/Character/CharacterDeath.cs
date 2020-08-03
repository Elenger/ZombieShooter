using UnityEngine;

public class CharacterDeath : MonoBehaviour
{
    [SerializeField] private ShowLosePanel _showLosePanel;
    [SerializeField] private CharacterSound _characterSound;
    [SerializeField] private Pause _pause;
    [SerializeField] private CharacterAnimation _characterAnimation;
    private bool alreadyDead = false;

    public void Death()
    {
        if (alreadyDead) return;
        alreadyDead = true;

        EventHub.current.OnCharacterLifeStatusDeath();

        _characterAnimation.Death();
        _characterSound.CharacterDeath_Sound();
    }

    private void ShowLosePanel()
    {
        _showLosePanel.ShowLose();
    }
}

