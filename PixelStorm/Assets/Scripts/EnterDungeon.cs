using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDungeon : MonoBehaviour
{
    public  void SceneLoad()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
