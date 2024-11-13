using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private int _repeats;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _spriteRenderer.DOColor(_targetColor, _duration)
            .SetLoops(_repeats, _loopType)
            .SetEase(Ease.Linear);
    }
}
