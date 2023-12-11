using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3 _direction = new Vector3(0, 360, 0);

    private void Start()
    {
        transform.DOLocalRotate(_direction, _duration, RotateMode.FastBeyond360).
            SetLoops(-1).SetEase(Ease.Linear);    
     }
}