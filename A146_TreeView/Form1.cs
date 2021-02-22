﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A146_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 이미지가 좌우 비율을 유지한 채로 픽쳐박스에 가득차게 그려줌
            TreeNode root = new TreeNode("영국의 왕"); // node객체인 root를 만든다.

            TreeNode stuart = new TreeNode("스튜어트 왕가");
            TreeNode hanover = new TreeNode("하노버 왕가");

            stuart.Nodes.Add("앤(1707~1714)");

            hanover.Nodes.Add("조지 1세(1714~1727)");
            hanover.Nodes.Add("조지 2세(1727~1760)");
            hanover.Nodes.Add("조지 3세(1760~1820)");
            hanover.Nodes.Add("조지 4세(1820~1830)");
            hanover.Nodes.Add("윌리엄 4세(1830~1837)");
            hanover.Nodes.Add("빅토리아(1837~1901)");

            
            treeView1.Nodes.Add(root);  // treeView1에root 노드 추가
            treeView1.ExpandAll();      // treeView1가 표시작때 모든 서브노드가 보이도록 확장시킨다.

            // root에 노드 추가
            root.Nodes.Add(stuart);
            root.Nodes.Add(hanover);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text == "앤(1707~1714)")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/Anne.jpg");
                txtMemo.Text = "앤 여왕은 1702년 3월 8일 잉글랜드와 스코틀랜드, ...";
            } else if(e.Node.Text == "조지 1세(1714~1727)")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/King_George_I.jpg");
                txtMemo.Text = "잉글랜드 의회에서 1701년 왕위결정법이 통과되면서, ...";
            }
        }
    }
}
