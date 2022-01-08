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
        AnimatorStateInfo stateInfo;
        stateInfo = playerAnim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            Debug.Log("���U�ť���");
            Anim("Player", "Player_Jump");
        }
        if (Input.GetKey(KeyCode.LeftShift) )
        {
            if (!stateInfo.IsName("Player_Jump")) 
            {
                Anim("Player", "Player_Swipe");
            }
            Debug.Log("�Ʀ�");
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
