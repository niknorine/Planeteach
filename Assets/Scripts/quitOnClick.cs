using UnityEngine;
using System.Collections;

public class quitOnClick : MonoBehaviour {

    public void Quit ()
    {
        UnityEditor.EditorApplication.isPlaying = false;

    }
}
