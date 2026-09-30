using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpanLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArrayButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();
            int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 };
            Span <int> span = numbers;
            DisplayListBox.Items.Add("Original values:");
            foreach (int value in span)
            {
                DisplayListBox.Items.Add(value);
            }
            span.Fill(5);
            DisplayListBox.Items.Add("After span.Fill(5):");
            foreach (int value in span)
            {
                DisplayListBox.Items.Add(value);
            }
            DisplayListBox.Items.Add("Original array after Fill:");
            foreach (int value in numbers)
            {
                DisplayListBox.Items.Add(value);
            }

        }
    }
}
