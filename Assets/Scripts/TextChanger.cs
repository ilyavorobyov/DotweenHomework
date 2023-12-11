using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private const string NewText = "��������� ������ ������. ";
    private const string TextAddition  = "��� ����������";
    private const string HackedText  = "������ ��� ����� �������!";

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(NewText, _duration));
        sequence.Append(_text.DOText(TextAddition, _duration).SetRelative());
        sequence.Append(_text.DOText(HackedText, _duration, true, ScrambleMode.All));
    }
}