using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterCC : MonoBehaviour
{
    [SerializeField] private TextMeshPro display;

    [SerializeField] private float timeRemainig;

    [SerializeField] private bool isActive;

    public string FormatTime(float input)
    {
        int _input = Mathf.FloorToInt(input);
        return FormatTime(_input);
    }
    public string FormatTime(int input)
    {
        
        int _second = input % 60;
        int _minute = Mathf.CeilToInt(input / 60);

        string _result = $"{formatTo2Digits(_minute)}:{formatTo2Digits(_second)}";
        return _result;
    }
    private string formatTo2Digits(float input)
    {
        string _output = input /10 >= 1 ? $"{input}" : $"0{input}";
        return _output;
    }
    public bool ContaintDigit(char _input)
    {
        return display.text.Contains("" + _input);
    }
    void Die()
    {
        Debug.Log("El Tiempo Se Acabó");
        isActive = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(isActive)
        if(timeRemainig > 0)
        {
            timeRemainig -= Time.deltaTime;
            display.text = FormatTime(timeRemainig);
           
        }
        else
        {
            Die();
        }
    }
}
