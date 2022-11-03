using UnityEngine;

public class StarterGame : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private BallMoving _ball;

    void Start()
    {
        GameObject temp = Instantiate(_ballPrefab.gameObject, transform);
        _ball = temp.GetComponent<BallMoving>();
    }

    public BallMoving GetBall() => _ball;
}
