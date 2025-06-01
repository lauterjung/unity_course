using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [field: TextArea(2, 6)]
    [field: SerializeField]
    public string Question { get; private set; }

    [field: SerializeField]
    public string[] Answers { get; private set; } = new string[4];

    [field: Range(0, 3)]
    [field: SerializeField]
    public int CorrectAnswerIndex { get; private set; }

    public string GetAnswer(int index)
    {
        return Answers[index];
    }
}
