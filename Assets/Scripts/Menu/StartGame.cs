using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    Button startGameButton;

    private void Awake()
    {
        startGameButton = GetComponent<Button>();
    }


    void Start()
    {
        startGameButton.onClick.AddListener(delegate { SceneManager.LoadScene(1); });
    }
}
