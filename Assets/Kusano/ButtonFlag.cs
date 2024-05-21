using UnityEngine;

public class ButtonFlag : MonoBehaviour
{
    public void ButtonOn()
    {
        GameObject.FindWithTag("client").GetComponents<CreateObjectAction>()[0].ExecuteAction(null);
        GameObject.FindWithTag("client").GetComponents<CreateObjectAction>()[1].ExecuteAction(null);
        GameObject.FindWithTag("client").GetComponent<DestroyAction>().ExecuteAction(null);
    }
}
