using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public string LevelToLoad;
    // Start is called before the first frame update
    void Start()
    {

        //playerPosData = FindObjectOfType<saveXandY>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //playerPosData.PlayerPosSave();
            SceneManager.LoadScene(LevelToLoad);
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    public void Use()
    {
        SceneManager.LoadScene(LevelToLoad);

    }
}
