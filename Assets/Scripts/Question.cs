using System;
using TMPro;
using UnityEngine;

public class Question : MonoBehaviour
{
    public Answer AnswerPrefab;
    public TMP_Text TitlePrefab;
    public Transform Container;
    public Action<bool> Answer;

    public void Construct(QuestionModel model)
    {
        var title = Instantiate(TitlePrefab, transform);
        title.text = model.Title;

        model.Answers.ForEach(answerModel =>
        {
            var answerInstance = Instantiate(AnswerPrefab, transform);
            answerInstance.Text.text = answerModel.Text;
            answerInstance.Button.onClick.AddListener(() => Answer.Invoke(answerModel.IsTrue));
        });
    }
}
