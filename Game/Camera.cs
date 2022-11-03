using UnityEngine;

public class Camera : MonoBehaviour
{
    private float _speed;

    private void Start()
    {
        _speed = PlayerPrefs.GetFloat("Speed");
    }

    private void Update()
    {
        gameObject.transform.position += Vector3.right * _speed * Time.deltaTime;
    }
}
