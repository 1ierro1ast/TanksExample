using DefaultNamespace;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private GameObject[] _casePrefabs;
    [SerializeField] private GameObject[] _towerPrefabs;
    
    private ICase _case;
    private ITower _tower;

    private void Awake()
    {
        _case = Instantiate(_casePrefabs[Random.Range(0, _casePrefabs.Length)], transform)
            .GetComponent<ICase>();
        
        _tower = Instantiate(_towerPrefabs[Random.Range(0, _towerPrefabs.Length)], transform)
            .GetComponent<ITower>();
        
        _tower.SetPosition(_case.TowerPosition);
    }
    
}
