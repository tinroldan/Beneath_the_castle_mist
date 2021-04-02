using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenURLFerret : MonoBehaviour
{
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }

    public void OpenScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
