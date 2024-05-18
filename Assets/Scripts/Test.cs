using UnityEngine;

public class Test : MonoBehaviour
{
    public TestModel Model;
    public Question QuestionPrefab;
    public RectTransform ResultsPanel;

    private int _index;
    private Question _question;

    private void Awake()
    {
        Results.QuestionsCount = Model.Questions.Count;
        OpenNextQuestion();
    }

    private void OpenNextQuestion()
    {
        if (_question != null)
        {
            Destroy(_question.gameObject);
        }
        if (_index > Model.Questions.Count - 1)
        {
            OpenResultsPanel();
            return;
        }
        var q = Model.Questions[_index++];
        var quetion = Instantiate(QuestionPrefab, transform);
        _question = quetion;
        quetion.Construct(q);
        quetion.Answer += (result) =>
        {
            if (result)
            {
                Results.Score++;
            }
            OpenNextQuestion();
        };
    }

    private void OpenResultsPanel()
    {
        gameObject.SetActive(false);
        ResultsPanel.gameObject.SetActive(true);
    }
}

public static class Results
{
    public static int Score;
    public static int QuestionsCount;
}