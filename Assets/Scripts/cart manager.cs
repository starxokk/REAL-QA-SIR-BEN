using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CartManager : MonoBehaviour
{
    public static CartManager Instance;

    public List<string> orderedItems = new List<string>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep it between scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddItem(string itemName)
    {
        orderedItems.Add(itemName);
    }

}
