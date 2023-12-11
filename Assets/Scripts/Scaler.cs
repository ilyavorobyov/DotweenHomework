using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;

    private float _additionalScale = 0.7f;

    private void Start()
    {
        transform.DOScale(_additionalScale, 3).SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}