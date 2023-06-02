using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField]private GameObject fadeCanvas;
    public void OnClickMainGame()
    {
        Instantiate(fadeCanvas);
            StartCoroutine(LoadMainGame());
    }

    private IEnumerator LoadMainGeame()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("MainGame");
    }
}
