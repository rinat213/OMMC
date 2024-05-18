using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Test", menuName = "ScriptableObjects/TestScriptableObject")]
public class TestModel : ScriptableObject
{
    public List<QuestionModel> Questions;
}

[Serializable]
public class QuestionModel
{
    public string Title;
    public List<AnswerModel> Answers;
}

[Serializable]
public class AnswerModel
{
    public string Text;
    public bool IsTrue;
}