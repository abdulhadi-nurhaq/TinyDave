using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    static void HideAllExceptThisOne()
    {
        GameObject[] all_Objs = GameObject.FindObjectsOfType<GameObject>();
        GameObject current = Selection.activeGameObject;

        foreach (GameObject g in all_Objs)
        {
            if (g != current)
                g.SetActive(false);
        }
    }
}
