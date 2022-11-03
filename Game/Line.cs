using UnityEngine;

public class Line : MonoBehaviour
{
    [SerializeField] private int _maxPossibleLineLenght;
    [SerializeField] private SpriteRenderer _lineSpriteRenderer;
    [SerializeField] BoxCollider2D _boxCollider2D;

    private void Start()
    {
        _lineSpriteRenderer.size = new Vector2(Random.Range(1, _maxPossibleLineLenght), 1) * 0.75f;
        _boxCollider2D.size = _lineSpriteRenderer.size;
    }
}
