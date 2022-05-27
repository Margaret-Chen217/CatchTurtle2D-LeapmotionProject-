using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator WaterAnim;
    public Animator FishAnim;
    public GameObject[] Turtles;
    // public GameObject Turtle2;
    // public GameObject Turtle3; 
    // public GameObject Turtle4;
    // public GameObject Turtle5;
    // public GameObject Turtle6;
    // public GameObject Turtle7;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("GameScene1");
    }

    public void playWaterAnim()
    {
        Debug.Log("ClickWater");
        WaterAnim.SetBool("WaterMove", true);
    }

    public void LargerTurtles()
    {
        for (int i = 0; i < 7; i++)
        {
            Turtles[i].transform.localScale = new Vector3(0.4f, 0.4f, 1);
        }

    }
    public void playFishAnim(){
        FishAnim.SetBool("FishMove", true);
    }

}
