using UnityEngine;
using System.Collections;

public class MainMethod : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    bool aboutusbox = false;
    bool mainmenu  = true;
 
    public void OnGUI()
    {
        if (mainmenu)
        {
            if (GUI.Button(new Rect(0, 0, Screen.width, Screen.height), "Bonjour superviseur"))
            {
                aboutusbox = true;
                mainmenu = false;
            }
        }
        if (aboutusbox)
        {
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), "Aujourd'hui , voud devrez surveillez les mots traitres et les absences au travail");
            
        }

    }

}
