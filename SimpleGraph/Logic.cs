using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraph
{
    public class Logic
    {
        public List<Node> Nodes { get; set; }
        public void Add(int value, int x, int y) => Nodes.Add(new Node(value,x,y));
        public void Remove(Node node)
        {
            node.RemoveNodes();
            Nodes.Remove(node);
        }
        public void ClearWas()
        {
            foreach (var item in Nodes)
            {
                item.was = false;
            }
        }
        public Logic()
        {
            Nodes = new List<Node>();
        }
        public List<string> GetCycles(List<Node> NotNeed)
        {
            foreach (var item in Nodes)
            {
                item.was = false;
                item.NotNeed = false;
            }
            foreach (var item in NotNeed)
            {
                item.NotNeed = true;
            }
            List<List<Node>> Ways = new List<List<Node>>();
            Stack<Node> stack = new Stack<Node>();
            foreach (var item in Nodes)
            {
                if (!item.NotNeed)
                    GetCyclesFrom(item, item, Ways, stack);
                item.NotNeed = true;
            }
            List<string> result = new List<string>();
            foreach (var item in Ways)
            {
                result.Add(string.Join(" ", item));
            }
            result.Sort();
            return result;
        }
        private void AddWay(List<List<Node>> Ways, Stack<Node> stack)
        {
            List<Node> Way = stack.ToList();
            if (Way.Count <= 3)
                return;
            Way.Reverse();
            foreach (var item in Ways)
            {
                if(item.Count == Way.Count)
                {
                    bool t = true;
                    for (int i = 0; i < item.Count; i++)
                    {
                        if(item[i] != Way[i])
                        {
                            t = false;
                            break;
                        }
                    }
                    if (t)
                        return;
                }
            }
            Ways.Add(stack.ToList());
        }
        private void GetCyclesFrom(Node node, Node start, List<List<Node>> Ways, Stack<Node> stack)
        {
            stack.Push(node);
            node.was = true;
            if(node == start && stack.Count!= 1)
            {
                AddWay(Ways,stack);
            }
            else
            {
                foreach (var item in node.Nodes)
                {
                    if (!item.NotNeed && (!item.was || item == start))
                        GetCyclesFrom(item, start,Ways,stack);
                }
            }
            node.was = false;
            stack.Pop();
        }
    }
}
