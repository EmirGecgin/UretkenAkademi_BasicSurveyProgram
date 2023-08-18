using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Outputs : MonoBehaviour
{
    [SerializeField] private GameObject _inputFieldName, _inputFieldSurname;
    [SerializeField] private string _nameOutput,_surnameOutput;
    [SerializeField] private GameObject _answerPanel, _questionPanel;
    [SerializeField] private Button _skipButton;
    [SerializeField] private TextMeshProUGUI _answerOne, _answerTwo, _answerThree, _ageText, _levelCase,_answerFive, _answerSix, _answerSeven, _scoreText;
    [SerializeField] private Slider ageSlider,scoreSlider;
    [SerializeField] private bool _isItClicking=false;
    private void Awake()
    {
        _answerFive.text = "-You share Unity projects on ";
    }
    private void Update()
    {
        GetAge();
        GetScore(); 
    }
    public void GetFirstQuestion()
    {
        string nameOne = _inputFieldName.GetComponent<TMP_InputField>().text;
        _nameOutput = nameOne;
        _answerOne.text = "-Your name is " + _nameOutput + ".";
        print(_nameOutput);
    }
    public void GetSecondQuestion()
    {
        string surnameOne = _inputFieldSurname.GetComponent<TMP_InputField>().text;
        _surnameOutput = surnameOne;
        _answerTwo.text = "-Your surname is " + _surnameOutput + ".";
        print(_surnameOutput);
    }
    public void Skip()
    {
        _questionPanel.SetActive(false);
        _answerPanel.SetActive(true);
        _skipButton.gameObject.SetActive(false);
    } 
    public void GetAge()
    {
        int age = (int)(ageSlider.value);
        string ageT =  age.ToString();
        _ageText.text = ageT;
        _answerThree.text = "-Your age is " + ageT + ".";
    }

    public void GetUnityLevel(int index)
    {
        switch (index)
        {
            case 0: _levelCase.text = "-Your Unity level is Advanced.";break;
            case 1: _levelCase.text = "-Your Unity level is Average."; break;
            case 2: _levelCase.text = "-Your Unity level is Beginner."; break;

        }
    }
    public void GetOtherPlatform(bool isItClicking)
    {
        if (isItClicking)
        {
            _answerFive.text += "Other ";
            
        }
    }
    public void GetGithubPlatform(bool isItClicking)
    {
        if (isItClicking)
        {
            _answerFive.text += "Github ";
        }
    }
    public void GetLinkledlnPlatform(bool isItClicking)
    {
        if (isItClicking)
        {
            _answerFive.text += "Linkedln ";
        }

    }
    public void GetYoutubePlatform(bool isItClicking)
    {
        if (isItClicking)
        {
            _answerFive.text += "Youtube ";
        }
    }
    public void GetHowOften(int index)
    {
        switch (index)
        {
            case 0:_answerSix.text="-You do project on Unity in a week."; break;
            case 1: _answerSix.text = "-You do project on Unity in a month."; break;
            case 2: _answerSix.text = "-You do project on Unity in a year."; break;
        }
    }
    public void GetScore()
    {
        int score = (int)(scoreSlider.value);
        string scoreT = score.ToString();
        _scoreText.text = scoreT;
        _answerSeven.text = "-Your score for Unity Interface is " + scoreT + ".";
    }
}
