using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToDataScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void returnToData()
    {
        SceneManager.LoadScene("DataScene");
    }
}
