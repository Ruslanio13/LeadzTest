using UnityEngine;

public class CheckBallCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Line"))
        {
            FinisherGame.instance.FinishGame();
        }
    }
}
