using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestAnimation : MonoBehaviour
{
    [SerializeField]
    private Animation test;
    
    // Start is called before the first frame update
    void Start()
    {

        Animation anim = test.GetComponent<Animation>();
        
        AnimationCurve scaleX = AnimationCurve.Linear(0.0f, 0.0f, 5.0f, 2.0f);
        Keyframe[] keys;
        keys = new Keyframe[3];
        keys[0] = new Keyframe(0.0f, 0.0f);
        keys[1] = new Keyframe(5.0f, 2.0f);
        keys[2] = new Keyframe(6.0f, 3.0f);
        AnimationCurve curve = new AnimationCurve(keys);
        AnimationClip animationClip;
        animationClip = new AnimationClip();
        animationClip.legacy = true;
        animationClip.SetCurve("", typeof(Transform), "localPosition.x", curve);
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
