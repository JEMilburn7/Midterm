using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuScript : MonoBehaviour
{
    public void gotoGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("gameplay");
    }
}
