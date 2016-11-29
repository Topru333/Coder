using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Coders
{
    class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public List<bool> Traverse(char symbol,List<bool> data)
        {
            if(Right == null && Left == null)
            {
                if(symbol.Equals(this.Symbol)){return data;}
                else { return null; }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;
                if(Left!=null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);
                    left = Left.Traverse(symbol, leftPath);
                }
                if(Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Traverse(symbol, rightPath);
                }
                if(left!=null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }
    }
    class HaffmanTree 
    {
        private List<Node> nodes = new List<Node>();
        private Node Root { get; set; }
        private Dictionary<char, int> Frequencies = new Dictionary<char, int>();

        public void Build(string source)
        {
            for (int i = 0;i < source.Length; i++)
            {
                if(!Frequencies.ContainsKey(source[i]))
                {
                    Frequencies.Add(source[i], 0);
                }
                Frequencies[source[i]]++;
            }
            foreach(var symbol in Frequencies)
            {
                nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }
            while (nodes.Count > 1)
            {
                List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList<Node>();
                if(orderedNodes.Count >=2)
                {
                    // Берем две самые многочисленные ветки
                    List<Node> taken = orderedNodes.Take(2).ToList<Node>();
                    // Создаем для них основную ветвь
                    Node parent = new Node()
                    {
                        Symbol = '*',
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };
                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent);
                }
                this.Root = nodes.FirstOrDefault();
            }
        }

        public BitArray Encode(string sourse)
        {
            this.Build(sourse);
            List<bool> encodedSourse = new List<bool>();
            for(int i = 0; i<sourse.Length; i++)
            {
                List<bool> encodedSymbol = this.Root.Traverse(sourse[i], new List<bool>());
                encodedSourse.AddRange(encodedSymbol);
            }
            BitArray bits = new BitArray(encodedSourse.ToArray());
            return bits;
        }

        public string Decode(BitArray bits)
        {
            Node current = this.Root;
            string decoded = "";
            foreach(bool bit in bits)
            {
                if(bit)
                {
                    if(current.Right!=null)
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left!=null)
                    {
                        current = current.Left;
                    }
                }
                if(IsLeaf(current))
                {
                    decoded += current.Symbol;
                    current = this.Root;
                }
            }
            return decoded;
        }
        public bool IsLeaf(Node node)
        {
            return (node.Left == null && node.Right == null);
        }

    }
}
