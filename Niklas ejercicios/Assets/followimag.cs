using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followimag : MonoBehaviour
{
    RectTransform Rt_;
    float FollowFroce = 0.95f;
    Vector2 lastPostition;

    private void Start()
    {
        Rt_ = GetComponent<RectTransform>();
    }
    private void Update()
    {
        lastPostition = Vector2.Lerp(Input.mousePosition, lastPostition, FollowFroce);
        Rt_.position = lastPostition;
    }
}
