using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDisplay : MonoBehaviour
{
    public GameObject[] objArray;    // �C���X�y�N�^�[���犄�蓖�Ă�
    GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        go = objArray[Random.Range(0, objArray.Length)];    // �z�񂩂烉���_���� GameObject �����o��
        ObjDisplay();
    }

    //�ŏ��ɉ摜�������_���ɕ\������
    public void ObjDisplay()
    {
        go.gameObject.SetActive(true);
    }

    //�摜�������i�{�^���������ꂽ��Ăяo�����j
    public void ObjNonDisplay()
    {
        go.gameObject.SetActive(false);
        Next();
    }

    //���̉摜��\������
    public void Next()
    {
        go = objArray[Random.Range(0, objArray.Length)];    // �z�񂩂烉���_���� GameObject �����o��
        go.gameObject.SetActive(true);
    }
}
