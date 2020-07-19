using UnityEngine;

public class PrefabFactory<T> : IFactory<T> where T : MonoBehaviour
{

    private GameObject _prefab;

    public PrefabFactory(GameObject prefab)
    {
        this._prefab = prefab;
    }

    public T Create()
    {
        GameObject tempGameObject = GameObject.Instantiate(_prefab) as GameObject;
        T objectOfType = tempGameObject.GetComponent<T>();
        return objectOfType;
    }
}
