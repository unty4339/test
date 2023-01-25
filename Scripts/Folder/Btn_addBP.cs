using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_addBP : MonoBehaviour
{

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        Folders.instance.AddPrint(transform.parent.gameObject);
    }
}