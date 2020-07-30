using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuPause : MonoBehaviour
{
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            isPaused = !isPaused;
        if (isPaused)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }
    void OnGUI()
    

        {
        GUI.contentColor = new Color(39, 231, 231, 255);
        GUI.backgroundColor = new Color(68, 62, 62, 255);
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.fontSize = 25;
        buttonStyle.fontStyle = FontStyle.Bold;
        if(isPaused)
        {
            if(GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 20, 180, 50), "Continuer", buttonStyle))
            {
                isPaused = false;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 +40, 180, 50), "Quitter", buttonStyle))
            {
                Application.LoadLevel("Menuprincipale");
            }
        }
    }

}
