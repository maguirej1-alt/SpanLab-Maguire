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

        private void StringSpanButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();
            string[] animals = { "cat", "bird", "dog", "fish", "cow" };
            Span<string> span = animals;
            foreach (string value in span)
            {
                DisplayListBox.Items.Add($"RESULT: {value}");
            }
            DisplayListBox.Items.Add($"Length:{ span.Length}");
        }

        private void SliceButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();
            int[] numbers = { 10, 20, 30, 40 };
            Span<int> span = numbers;
            Span<int> slice1 = span.Slice(1);
            DisplayListBox.Items.Add("Slice starting at index 1:");

            foreach (int value in slice1)
            {
                DisplayListBox.Items.Add(value);
            }
            Span<int> slice2 = span.Slice(1, 2);

            DisplayListBox.Items.Add("Slice starting at index 1 with length 2:");
            foreach (int value in slice2)
            {
                DisplayListBox.Items.Add(value);
            }

            slice2[0] = 99;

            DisplayListBox.Items.Add("Original array after changing slice2:");
            foreach (int value in numbers)
            {
                DisplayListBox.Items.Add(value);
            }



        }
    }
}
