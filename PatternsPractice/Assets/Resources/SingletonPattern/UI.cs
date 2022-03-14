using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UI : MonoBehaviour
{
    [SerializeField] InputField numInputField;
    public void ChangeScene()
    {
        try
        {
            int num = int.Parse(numInputField.text);
            if (num < 1 || num > 100) return;
            Singleton.GetInstance().SetNum(num);
        } catch (Exception e){
            Debug.LogError("숫자만 입력!");
            return;
        }
        SceneManager.LoadScene("SingletonScene");
    }
}
