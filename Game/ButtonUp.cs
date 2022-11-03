using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonUp : MonoBehaviour, IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private StarterGame _level;
    private bool isPressed;
    private BallMoving _ball;

    private void Start()
    {
        _ball = _level.GetBall();
    }

    public void OnUpdateSelected(BaseEventData data)
    {
        if (isPressed)
        {
            _ball.LiftBall();
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
        _ball.LiftBall();
    }
}
