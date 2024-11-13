using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private int _repeats;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(" все не успел", _duration))
            .Append(_text.DOText(" что-то новое", _duration).SetRelative())
            .Append(_text.DOText("Еше новее", _duration, scrambleMode:ScrambleMode.All))
            .SetLoops(_repeats, _loopType)
            .SetEase(Ease.Linear);
    }
}
