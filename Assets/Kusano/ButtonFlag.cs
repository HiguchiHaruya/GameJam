using UnityEngine;

public class ButtonFlag : MonoBehaviour
{
    public void ButtonOn()
    {
        GameObject.FindWithTag("client").GetComponents<CreateObjectAction>()[0].ExecuteAction(null);　//次のお客さん
        GameObject.FindWithTag("client").GetComponents<CreateObjectAction>()[1].ExecuteAction(null);　//左移動
        GameObject.FindWithTag("client").GetComponent<DestroyAction>().ExecuteAction(null); //今のものを消す
    }
}
