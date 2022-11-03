using System.Collections;
using UnityEngine;

public class LineSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _line;
    [SerializeField] private float _offsetX;
    [SerializeField] private float _pastLinePosX;
    private float _playerSpeed;

    private void Start()
    {
        StartCoroutine(SpawnLine());
        _playerSpeed = PlayerPrefs.GetFloat("Speed");
    }

    public IEnumerator SpawnLine()
    {
        while (true)
        {
            Instantiate(_line, GetRandomPosition(),Quaternion.identity, gameObject.transform);
            yield return new WaitForSeconds(15 * 1 / _playerSpeed);
        }
    }

    private Vector3 GetRandomPosition()
    {
        float yPos = Random.Range(-4f, 4f);
        return new Vector3(_pastLinePosX += _offsetX, yPos);
    }
}
