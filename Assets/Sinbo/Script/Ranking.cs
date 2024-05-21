using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{

    [SerializeField, Header("���l")]
    int point;

    string[] ranking = { "�����L���O1��", "�����L���O2��", "�����L���O3��", "�����L���O4��", "�����L���O5��" };
    int[] rankingValue = new int[5];

    [SerializeField, Header("�\��������e�L�X�g")]
    Text[] rankingText = new Text[5];

    // Use this for initialization
    void Start()
    {
        GetRanking();

        point = Select._score; //�X�R�A���擾
        //�f�o�b�O�p�@point = 300;

        SetRanking(point);

        for (int i = 0; i < rankingText.Length; i++)
        {
            int x = i + 1;
            rankingText[i].text = (x + (": ") + rankingValue[i].ToString());
        }
    }

    /// <summary>
    /// �����L���O�Ăяo��
    /// </summary>
    void GetRanking()
    {
        //�����L���O�Ăяo��
        for (int i = 0; i < ranking.Length; i++)
        {
            rankingValue[i] = PlayerPrefs.GetInt(ranking[i]);
        }
    }
    /// <summary>
    /// �����L���O��������
    /// </summary>
    void SetRanking(int _value)
    {
        //�������ݗp
        for (int i = 0; i < ranking.Length; i++)
        {
            //�擾�����l��Ranking�̒l���r���ē���ւ�
            if (_value > rankingValue[i])
            {
                var change = rankingValue[i];
                rankingValue[i] = _value;
                _value = change;
            }
        }

        //����ւ����l��ۑ�
        for (int i = 0; i < ranking.Length; i++)
        {
            PlayerPrefs.SetInt(ranking[i], rankingValue[i]);
        }
    }
}