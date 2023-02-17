using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public int ang = 900;
    private Tween tweener;
    private void OnEnable() {
        tweener = transform.DORotate(Vector3.right * ang, 20f, RotateMode.FastBeyond360);
    }
}
