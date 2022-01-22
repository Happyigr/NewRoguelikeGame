using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// ������ ������� ���������� ����� ��������� �� �����(nodes) � ��������� ��������
public class MyGraph
{
    //����� ���������� � ����
    public class NodeInfo
    {
        public Vector2Int Pos;               //������� ����
        public List<Vector2Int> Dirs; //����������� ������� ���� � ����

        public NodeInfo(Vector2Int pos, List<Vector2Int> dirs)
        {
            Pos = pos;
            Dirs = dirs;
        }
    }

    public List<NodeInfo> Generate(int amount)
    {
        var nodes = CreateGraph(amount);
        var start = nodes.Keys.First();

        var visited = new HashSet<Vector2Int>();
        var queue = new Queue<Vector2Int>();

        queue.Enqueue(start);
        visited.Add(start);

        var result = new List<NodeInfo>();

        while (queue.Count != 0)
        {
            var node = queue.Dequeue();
            var dirs = new List<Vector2Int>();

            foreach (var childNode in nodes[node])
            {
                if (!visited.Contains(childNode))
                {
                    queue.Enqueue(childNode);
                    visited.Add(childNode);
                }

                dirs.Add(childNode - node);
            }
            result.Add(new NodeInfo(node, dirs));
        }

        return result;
    }

    public Dictionary<Vector2Int, HashSet<Vector2Int>> CreateGraph(int amount)
    {
        // ��������� ����
        var n1 = new Vector2Int(0, 0);

        // ���� ����� �� ����� ���������� node
        // ������ ����� ������������� ����, � ��������� ����� ��� ������ ������� ���� � ����� ����
        var nodes = new Dictionary<Vector2Int, HashSet<Vector2Int>>();
        nodes.Add(n1, new HashSet<Vector2Int>());

        // �������� ���������� ��������� ����
        var dxdy = new Vector2Int[]
        {
            new Vector2Int(0 , 1),    //������
            new Vector2Int(1 , 0),    //������
            new Vector2Int(0 , -1),   //�����
            new Vector2Int(-1 , 0)    //�����
        };

        // ���������� ������� ������������ �� ��� �� ����� ������ �����(��� ��� ���� �������)


        // nodesAmount - 1 ��� ��� ������� ���� �� ��� ��������
        for (int i = 0; i < amount - 1; i++)
        {
            bool next = false;
            
            while (!next)
            {
                var n2 = n1 + dxdy[Random.Range(0, dxdy.Length)];

                if (!nodes.ContainsKey(n2))
                {
                    next = true;

                    // ��������� ���� � ����
                    nodes.Add(n2, new HashSet<Vector2Int>());

                    nodes[n1].Add(n2);
                    nodes[n2].Add(n1);    
                }

                else
                {
                    nodes[n1].Add(n2);
                    nodes[n2].Add(n1);
                }

                n1 = n2;
            }
        }

        return nodes;
    }
}
