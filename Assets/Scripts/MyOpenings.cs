using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������
/// </summary>
public class MyOpenings : MonoBehaviour
{
    [System.Serializable]
    public class Opening
    {
        /// <summary>
        /// ������� �� ������ � �����
        /// </summary>
        public Vector2Int Pos;

        /// <summary>
        /// ������ ������ (�����, �����, ����� � �.�.)
        /// </summary>
        public GameObject GameObject;
    }

    [SerializeField]
    private Opening top;

    [SerializeField]
    private Opening right;

    [SerializeField]
    private Opening bottom;

    [SerializeField]
    private Opening left;

    private List<Opening> list;

    public List<Opening> GetOpenings()
    {
        if (list == null)
        {
            list = new List<Opening>()
            {
                top,
                right,
                bottom,
                left
            };
        }

        return list;
    }
}
