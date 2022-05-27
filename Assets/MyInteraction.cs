using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;
using Leap.Unity.Interaction;

using System;
public class MyInteraction : MonoBehaviour
{
    //public LeapServiceProvider LeapServiceProvider;
    // Start is called before the first frame update
    public Vector2 unityposition;
    public Vector3 leapposition;
    void Start()
    {
        unityposition = new Vector2(0, 0);
        leapposition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Hand _leftHand = Hands.Left;
        //if(_leftHand != null){
        //    Debug.Log("getLeftHand");
        //}
        Hand _rightHand = Hands.Right;
        Hand _prioritisedHand = Hands.Left ?? Hands.Right;
        Hand _specificHand = Hands.Get(Chirality.Left);
        List<Hand> _allHands = Hands.Provider.CurrentFrame.Hands;
        if (_rightHand == null){
            unityposition = new Vector2(0, 0);
            Debug.Log("no hand");
        }else{
            leapposition.x = _rightHand.PalmPosition.x;
            leapposition.y = _rightHand.PalmPosition.y;
            leapposition.z = _rightHand.PalmPosition.z;
            Debug.Log(leapposition);
            unityposition = transition(leapposition);
            //Debug.Log(unityposition);
        }
        this.transform.position = unityposition;
    }

    Vector2 transition(Vector3 lposition)
    {
        Vector2 uposition;
        uposition.x = lposition.x;
        uposition.y = -lposition.z - 7;
        return uposition;
    }
    void OnUpdateHand(Hand _hand)
    {
        // Debug.Log("1");
        // float _pinchStrength = _hand.PinchStrength;
        // float _pinchDistance = _hand.PinchDistance;
        // Vector3 _pinchPosition = _hand.GetPinchPosition();
        // //Vector3 _predictedPinchPosition = _hand.GetPredictedPinchPosition();
        // bool isPinching = _hand.IsPinching();
        // if (isPinching)
        // {
        //     Debug.Log("_pinchPosition");
        // }
    }
    private void OnTriggerStay2D(Collider2D other) {
        //测试成为other子物体    
        Debug.Log("TriggerRnter");
        other.transform.parent = transform;
    }
}
