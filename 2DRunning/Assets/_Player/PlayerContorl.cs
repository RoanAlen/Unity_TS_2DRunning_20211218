using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorl : MonoBehaviour
{
    public Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("按下空白鍵");
            Anim("Player", "Player_Jump");
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("滑行");
            Anim("Player", "Player_Swipe");
        }
    }
    public void Anim(string AnimLayerName,string AnimStateName)
    {
        if (playerAnim != null)
        {
            playerAnim.Play($"{AnimLayerName}.{AnimStateName}");
        }
    }
}
