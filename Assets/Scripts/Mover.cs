using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3 _target;
    private float _distance = 2;

    private void Awake()
    {
        _target = new Vector3(transform.position.x + _distance, 
            transform.position.y, transform.position.z);
    }

    private void Start()
    {
        transform.DOMove(_target, _duration).SetLoops(-1, LoopType.Yoyo).
            SetEase(Ease.Linear); 
    }
}