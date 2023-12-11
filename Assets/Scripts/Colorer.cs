using UnityEngine;
using DG.Tweening;

public class Colorer : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _startColor;
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;

    private void Awake()
    {
        _material.color = _startColor;
    }

    private void Start()
    {
        _material.DOColor(_targetColor, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}