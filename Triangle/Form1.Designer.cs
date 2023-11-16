namespace MyWindowsFormsApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
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
        
        // // Set the button to return a value of OK when clicked.
        // button1.DialogResult = DialogResult.OK;
        this.button1 = new System.Windows.Forms.Button();
        this.button1.Dock = DockStyle.Top;
        this.button1.Text = "Generate Triangle";
        this.button1.Click += Button1_Click;
        // // Add the button to the form.
        this.Controls.Add(button1);
        
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.AcceptsReturn = true;
        this.textBox1.AcceptsTab = true;
        this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBox1.Multiline = true;
        this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        // this.textBox1.Text = "Initial text contents of the TextBox.";  
        this.Controls.Add(this.textBox1);


        // this.components = new System.ComponentModel.Container();
        // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 480);
        this.Text = "妳的學號";

        this.ResumeLayout(false);
        this.PerformLayout();

        
    }

    // private void InitializeMyButton()
    // {
    //     // Create and initialize a Button.
    //     Button button1 = new Button();
    
    //     // Set the button to return a value of OK when clicked.
    //     // button1.DialogResult = DialogResult.OK;
    //     button1.Click += new System.EventHandler(this.Button1_Click);

    //     // Add the button to the form.
    //     // Controls.Add(button1);
    // }

    #endregion
}
