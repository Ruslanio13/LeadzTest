using UnityEngine;
using TMPro;

public class DifficultyButton : MonoBehaviour
{
    [SerializeField] private DifficultyLevel _difficulty;
    [SerializeField] private TextMeshProUGUI _difficultyText;

    private enum DifficultyLevel
    {
        EASY = 1,
        MIDDLE,
        HARD
    }

    public void PickDifficulty()
    {
        PlayerPrefs.SetInt("Difficulty", (int)_difficulty);
        _difficultyText.text = "Picked difficulty: " + _difficulty.ToString();
    }

}