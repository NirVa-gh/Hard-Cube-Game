using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ValueOfLvl : MonoBehaviour
{

    public int LvlValue = 0;
    public TMP_Text LvlValueText;
  
    void Start()
    {
        LvlValue = SceneManager.GetActiveScene().buildIndex;
    }


    void Update()
    {
        LvlValueText.text = "Level " + (SceneManager.GetActiveScene().buildIndex + 1).ToString();
    }
}
