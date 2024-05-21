using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDisplay : MonoBehaviour
{
    public GameObject[] objArray;    // インスペクターから割り当てる
    GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        go = objArray[Random.Range(0, objArray.Length)];    // 配列からランダムな GameObject を取り出す
        ObjDisplay();
    }

    //最初に画像をランダムに表示する
    public void ObjDisplay()
    {
        go.gameObject.SetActive(true);
    }

    //画像を消す（ボタンが押されたら呼び出される）
    public void ObjNonDisplay()
    {
        go.gameObject.SetActive(false);
        Next();
    }

    //次の画像を表示する
    public void Next()
    {
        go = objArray[Random.Range(0, objArray.Length)];    // 配列からランダムな GameObject を取り出す
        go.gameObject.SetActive(true);
    }
}
