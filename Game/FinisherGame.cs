using UnityEngine;
using TMPro;

public class FinisherGame : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _gameCanvas;
    [SerializeField] private GameObject _level;
    [SerializeField] private TimeCount _timeCount;
    [SerializeField] private TextMeshProUGUI _time;
    [SerializeField] private TextMeshProUGUI _tries;
    public static FinisherGame instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void FinishGame()
    {
        if (_gameOverCanvas.activeInHierarchy)
            return;
        _gameOverCanvas.SetActive(true);
        _gameCanvas.SetActive(false);
        _level.SetActive(false);
        PlayerPrefs.SetInt("Tries", PlayerPrefs.GetInt("Tries") + 1);
        _time.text = "Time: " + _timeCount.GetTime().ToString();
        _tries.text = "Tries: " + PlayerPrefs.GetInt("Tries").ToString();
    }
}
