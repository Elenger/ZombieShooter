using System.Collections;
using TMPro;
using UnityEngine;

public class ShowBulletCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _bulletCount;
    private float _reloadTime;
    private string _defaultBulletCount;


    public void ShowCount(int bulletCount)
    {
        if (bulletCount == 0)
        {
            _bulletCount.text = "Reloading...";
            StartCoroutine("StartReload");
        }
        else
        {
            _bulletCount.text = "Bullet: " + bulletCount;
        }
    }

    IEnumerator StartReload()
    {
        yield return new WaitForSeconds(_reloadTime);
        _bulletCount.text = "Bullet: " + _defaultBulletCount;
    }

    public void SetReloadTime(float reloadTime)
    {
        _reloadTime = reloadTime;
    }

    public void SetDefaultBulletCount(int defaultBulletCount)
    {
        _defaultBulletCount = defaultBulletCount.ToString();
        _bulletCount.text = "Bullet: " + _defaultBulletCount;
    }
}
