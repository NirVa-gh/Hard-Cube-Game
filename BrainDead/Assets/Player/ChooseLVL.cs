using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChooseLVL : MonoBehaviour
{
    public void PushToLvl(int IndexOfLvl)
    {
        SceneManager.LoadScene(IndexOfLvl);
    }
}
