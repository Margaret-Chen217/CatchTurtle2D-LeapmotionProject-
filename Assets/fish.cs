using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class fish: MonoBehaviour
{

    Animator FishAnim;
    // Start is called before the first frame update
    void Start()
    {
        FishAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        Debug.Log("OnMouseDown");
        FishAnim.SetBool("FishMove", true);
    }
}
