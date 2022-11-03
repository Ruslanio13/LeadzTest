using System.Collections;
using UnityEngine;

public class BallMoving : MonoBehaviour
{
    [SerializeField] private float _speedStraight;
    [SerializeField] private float _liftSpeed;

    private void Start()
    {
        CalculateStraightSpeed();
        StartCoroutine(UpgradeSpeed());
    }

    void Update()
    { 
        gameObject.transform.position += Vector3.right * _speedStraight * Time.deltaTime;
        gameObject.transform.position += Vector3.down * _liftSpeed * Time.deltaTime;
    }

    public void LiftBall()
    {
        gameObject.transform.position += Vector3.up * Time.deltaTime * _liftSpeed * 2;
    }

    private IEnumerator UpgradeSpeed()
    {
        while (true)
        {
            _liftSpeed *= 1.1f;
            yield return new WaitForSeconds(15f);
        }
    }

    private void CalculateStraightSpeed()
    {
        switch (PlayerPrefs.GetInt("Difficulty", 1))
        {
            case 1:
                _speedStraight *= .8f;
                break;
            case 3:
                _speedStraight *= 1.2f;
                break;
        }
        PlayerPrefs.SetFloat("Speed", _speedStraight);
    }

    public float GetBallSpeed() => _speedStraight;
}
