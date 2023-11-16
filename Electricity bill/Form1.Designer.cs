namespace MyWindowsFormsApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    private Label label1, label2, show_ans;
    private TextBox textBox1;
    private Button button1;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.label1.Location = new Point(20, 20);
        this.label1.Text = "輸入用電度數";
        this.Controls.Add(this.label1);

        this.label2 = new System.Windows.Forms.Label();
        this.label2.Location = new Point(20, 120);
        this.label2.Text = "電費";
        this.Controls.Add(this.label2);

        this.show_ans = new System.Windows.Forms.Label();
        this.show_ans.Location = new Point(200, 120);
        this.show_ans.Text = "Label3";
        this.Controls.Add(this.show_ans);
        
        this.textBox1 = new System.Windows.Forms.TextBox();
        // this.SuspendLayout();
        this.textBox1.Location = new Point(200, 20);

        this.Controls.Add(this.textBox1);

        this.button1 = new System.Windows.Forms.Button();
        this.button1.Location = new Point(20, 200);
        this.button1.Text = "計算電費";
        this.button1.Click += Button1_Click;
        // Add the button to the form.
        this.Controls.Add(button1);
        

        

        // this.components = new System.ComponentModel.Container();
        // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 600);
        this.Text = "妳的學號";

        this.ResumeLayout(false);
        this.PerformLayout();

        
    }

    #endregion
}
