using UnityEngine;

public class ButtonFlag : MonoBehaviour
{
    public void ButtonOn()
    {
        GameObject.FindWithTag("client").GetComponents<CreateObjectAction>()[0].ExecuteAction(null);@//Ÿ‚Ì‚¨‹q‚³‚ñ
        GameObject.FindWithTag("client").GetComponents<CreateObjectAction>()[1].ExecuteAction(null);@//¶ˆÚ“®
        GameObject.FindWithTag("client").GetComponent<DestroyAction>().ExecuteAction(null); //¡‚Ì‚à‚Ì‚ğÁ‚·
    }
}
