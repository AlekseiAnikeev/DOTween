using DG.Tweening;
using UnityEngine;

public class Sequences : MonoBehaviour
{
    [SerializeField] private float _yEndValue;
    [SerializeField] private float _xEndValue;
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _firstPosition;
    [SerializeField] private Vector3 _secondPosition;
    [SerializeField] private Vector3 _scale;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMoveY(_yEndValue, _duration))
            .Insert(0f, transform.DORotate(_firstPosition, _duration))
            .Append(transform.DOMoveX(_xEndValue, _duration))
            .Insert(4f, transform.DORotate(_secondPosition, _duration))
            .Insert(0f, transform.DOScale(_scale, sequence.Duration()))
            .SetLoops(_repeats, _loopType)
            .SetEase(Ease.Linear);
    }
}