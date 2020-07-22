using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLoseWinPanelEnable : MonoBehaviour
{
    [SerializeField] Pause _pause;
    private void OnEnable()
    {
        _pause.OnPause();
    }

    private void OnDisable()
    {
        _pause.OnPause();
    }
}
