using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManeger : MonoBehaviour {
    public Button Restart;

    public void InputRes()
    {
        SceneManager.LoadScene("Main");
    }
}
