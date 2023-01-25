using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Folders : MonoBehaviour
{
    public static Folders instance;
    GameObject SelectedObject;
    Color Selected = new Color(0f, 0.5f, 0.8f);
    Color Unselected = new Color(0.2f, 0.2f, 0.2f);

    public void Start()
    {
        Folders.instance = this;
    }

    public void Check(GameObject obj)
    {
        //選択済ならグレーに戻す
        if (SelectedObject != null) SelectedObject.GetComponent<Image>().color = Unselected;
        
        //選択する
        SelectedObject = obj;
        obj.GetComponent<Image>().color = Selected;


    }

    public void AddPrint(GameObject envObj)
    {
        EnvList env = envObj.GetComponent<EnvList>();
        env.amountPrint += 1;

        GameObject print = Resources.Load("Print") as GameObject;
        print = GameObject.Instantiate(print, Vector3.zero, Quaternion.identity, envObj.transform);
        print.transform.position = new Vector3(0, -20.0f * env.amountPrint) + envObj.transform.position;
    }

}
