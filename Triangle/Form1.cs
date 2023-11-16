namespace MyWindowsFormsApp;
using System;
using System.Windows.Forms;

public partial class Form1 : Form
{      
    public Form1()
    {
        InitializeComponent();
    }
    private void Button1_Click(object sender, EventArgs e)
    {
        
        int height = 6;
        int width = 2 * height - 1;
        string triangle = " ";

        for (int i = 0; i < height; i++)
        {
            triangle += Environment.NewLine;
            for (int j = 0; j < width; j++)
            {
                if (j >= (width / 2 - i) && j <= (width / 2 + i))
                {
                    triangle += "*";
                }
                else
                {
                    triangle += " ";
                }
            }
        }

        textBox1.Text = triangle;
    }
}
