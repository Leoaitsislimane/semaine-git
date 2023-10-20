using UnityEngine;
using UnityEngine.SceneManagement;

public class lancementjeu : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Adrien");
        }
    }
}