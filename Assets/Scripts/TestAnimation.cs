using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestAnimation : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Animation anim = GetComponent<Animation>();
        
        AnimationCurve scaleX = AnimationCurve.Linear(0.0f, 0.0f, 5.0f, 2.0f);
        AnimationClip animationClip;
        animationClip = new AnimationClip();
        animationClip.legacy = true;
        animationClip.SetCurve("", typeof(Transform), "localPosition.x", scaleX);
        anim.AddClip(animationClip, "test");
        anim.wrapMode = WrapMode.Loop;
        anim.Play("test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateAnimation()
    {
    }


}
