using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drawing;
using SimpleGraph;

namespace GraphF
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }
        DrawingGraph draw;
        private void GraphForm_Load(object sender, EventArgs e)
        {
            draw = new DrawingGraph(Picture.Size);
            was = new List<int>();
            SelectedForTask = new List<Node>();
        }
        private void UPDImage() => Picture.Image = draw.Draw();
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileGraph file = new FileGraph(openFileDialog.FileName);
                    draw.graph = file.OpenGraph();
                    was.Clear();
                    foreach (var item in draw.graph.Nodes)
                    {
                        was.Add(item.Value);
                    }
                    UPDImage();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileGraph file = new FileGraph(saveFileDialog.FileName);
                    file.SaveGraph(draw.graph);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        List<int> was;
        Node SelectedNode = null;
        List<Node> SelectedForTask;
        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (SelectBtn.Checked)
            {
                Node n = draw.GetNode(e.Location);
                if (SelectedForTask.Contains(n))
                    SelectedForTask.Remove(n);
                else
                    SelectedForTask.Add(n);
                SelectedOut.Text = string.Join(", ", SelectedForTask);
            }
            else if (NodeBtn.Checked)
            {
                if (AddBtn.Checked)
                {
                    if (draw.PlaceFree(e.Location))
                    {
                        int value = 0;
                        while (was.Contains(value))
                        {
                            value++;
                        }
                        was.Add(value);
                        draw.graph.Add(value, e.X, e.Y);
                    }
                    UPDImage();
                }
                else
                {
                    Node node = draw.GetNode(e.Location);
                    if (node != null)
                    {
                        was.Remove(node.Value);
                        draw.graph.Nodes.Remove(node);
                        UPDImage();
                    }
                }
            }
            else
            {
                if (SelectedNode == null)
                    SelectedNode = draw.GetNode(e.Location);
                else
                {
                    Node second = draw.GetNode(e.Location);
                    if (SelectedNode != second && second != null)
                    {
                        if (AddBtn.Checked)
                        {
                            try
                            {
                                second.AddNode(SelectedNode);
                            }
                            catch (Exception)
                            {
                            }
                        }
                        else
                            second.RemoveNode(SelectedNode);
                    }
                    UPDImage();
                    SelectedNode = null;
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SelectedForTask.Clear();
            SelectedOut.Text = "";
        }

        private void GetWayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> Ways = draw.graph.GetCycles(SelectedForTask);
                if (Ways.Count != 0)
                    MessageBox.Show(string.Join("\r\n", Ways));
                else
                    MessageBox.Show("Циклы остутсвуют");


            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно");
            }
        }

    }
}
