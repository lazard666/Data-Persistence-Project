using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    public string playerName;
    public TMP_InputField inputPlayerName;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        
    }

    private void Update()
    {
        
    }

   public void StartGame()
    {
        playerName = inputPlayerName.text;

        if(playerName != "")
        {
            SceneManager.LoadScene(1);
        }
        
        else
        {
            Debug.Log("Du hast keinen Namen angegeben");
        }
    }
}
