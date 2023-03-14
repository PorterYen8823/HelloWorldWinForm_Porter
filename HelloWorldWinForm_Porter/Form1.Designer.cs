namespace HelloWorldWinForm_Porter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btnSayHello = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCount = new Button();
            lblCurrentTime = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(234, 74);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(192, 51);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hello";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += btnSayHello_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 87);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 153);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // btnCount
            // 
            btnCount.Location = new Point(234, 140);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(192, 51);
            btnCount.TabIndex = 3;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Location = new Point(74, 215);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(138, 23);
            lblCurrentTime.TabIndex = 4;
            lblCurrentTime.Text = "lblCurrentTime";
            // 
            // button1
            // 
            button1.Location = new Point(451, 140);
            button1.Name = "button1";
            button1.Size = new Size(192, 51);
            button1.TabIndex = 5;
            button1.Text = "Count";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(649, 139);
            button2.Name = "button2";
            button2.Size = new Size(192, 51);
            button2.TabIndex = 6;
            button2.Text = "Count";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 449);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblCurrentTime);
            Controls.Add(btnCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSayHello);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Label label1;
        private Label label2;
        private Button btnCount;
        private Label lblCurrentTime;
        private Button button1;
        private Button button2;
    }
}