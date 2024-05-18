using TMPro;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
    public string scoreText;

    private void Awake()
    {
        var text = GetComponent<TMP_Text>();
        text.text = string.Format(scoreText, Results.Score, Results.QuestionsCount);
    }
}
