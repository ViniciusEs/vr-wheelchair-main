using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrimarySceneReload : MonoBehaviour
{
    // Start is called before the first frame update
    public PrimaryButtonWatcher watcher;
    public bool IsPressed = false; // public to show button state in the Unity Inspector window

    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
    }

    public void onPrimaryButtonEvent(bool pressed)
    {
        IsPressed = pressed;
 
        if (pressed)
            Reload();
    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

