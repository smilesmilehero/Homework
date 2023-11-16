namespace MyWindowsFormsApp;
using System;
using System.Windows.Forms;

public partial class Form1 : Form
{      
    public Form1()
    {
        InitializeComponent();
    }
    private void Button1_Click(object sender, EventArgs e){

        if(double.TryParse(textBox1.Text, out double bill)){
            double totalCost = 0.0;

            if (bill <= 500){
                totalCost = bill * 2.56;
            }
            else if (bill <= 600){
                totalCost = 500 * 2.56 + (bill - 500) * 3.2;
            }
            else if (bill <= 700){
                totalCost = 500 * 2.56 + 100 * 3.2 + (bill - 600) * 4.5;
            }
            else{
                totalCost = 500 * 2.56 + 100 * 3.2 + 100 * 4.5 + (bill - 700) * 55;
            }   
            show_ans.Text = "總電費：" + totalCost.ToString("F2") + " 元";
        }
    }
}
