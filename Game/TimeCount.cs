using UnityEngine;
using TMPro;
using System.Collections;

public class TimeCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _time;
    private int _timeInt = 0;

    private void Start()
    {
        StartCoroutine(CountTime());
    }

    private IEnumerator CountTime()
    {
        while (true)
        {
            _time.text = _timeInt.ToString();
            _timeInt++;
            yield return new WaitForSeconds(1);
        }
    }

    public int GetTime() => _timeInt;
}
