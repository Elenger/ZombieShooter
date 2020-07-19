using UnityEngine;

public class PrefabFactory<T> : IFactory<T> where T : MonoBehaviour
{

    private GameObject[] _prefabs;
    private GameObject _prefab;

    public PrefabFactory(GameObject prefab = null, GameObject[] prefabs = null)
    {
        this._prefabs = prefabs;
        this._prefab = prefab;
    }

    public T Create()
    {
        GameObject prefab;
        if (_prefabs != null)
        {
            prefab = _prefabs[Random.Range(0, _prefabs.Length)];
        }
        else prefab = _prefab;


        GameObject tempGameObject = GameObject.Instantiate(prefab) as GameObject;
        T objectOfType = tempGameObject.GetComponent<T>();
        return objectOfType;
    }
}
