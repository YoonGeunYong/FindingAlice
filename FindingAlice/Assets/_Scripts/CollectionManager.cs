using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionManager : MonoBehaviour
{
    [SerializeField] GameObject[] collection;

    
    GameData gameData;

    void Awake()
    {
        gameData = DataController.instance.LoadGameDate();
    }

    void Start()
    {
        
    }

    void Update()
    {
        gameData. 
    }

    public void GetItem(int array)
    {
        collection[array].SetActive(false);

    }
}
