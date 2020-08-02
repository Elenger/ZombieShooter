using System;
using UnityEngine;

public class EventHub : MonoBehaviour
{
    public static EventHub current;

    private void Awake()
    {
        current = this;
    }

    #region CharacterEvents
    /// <summary>
    /// true = respawn, false = death
    /// </summary>
    public event Action CharacterLifeStatusChanged;
    public void OnCharacterLifeStatusDeath()
    {
        CharacterLifeStatusChanged?.Invoke();
    }
    #endregion
}