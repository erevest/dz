
namespace dz
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(65, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Введите X:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(68, 90);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 22);
      this.textBox1.TabIndex = 1;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(68, 197);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(501, 284);
      this.richTextBox1.TabIndex = 2;
      this.richTextBox1.Text = "";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(68, 146);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Ответ:";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(622, 237);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(134, 61);
      this.button1.TabIndex = 4;
      this.button1.Text = "подсчитать";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(799, 554);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
  }
}

