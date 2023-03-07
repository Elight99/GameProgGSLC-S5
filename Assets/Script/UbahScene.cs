using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UbahScene : MonoBehaviour
{
    public void changeMyScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}