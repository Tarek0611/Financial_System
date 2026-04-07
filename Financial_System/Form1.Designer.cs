namespace Financial_System
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn1 = new Button();
            pictureBox1 = new PictureBox();
            lbl1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(468, 223);
            btn1.Name = "btn1";
            btn1.Size = new Size(110, 55);
            btn1.TabIndex = 1;
            btn1.Text = "اطلبني للزواج";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.White;
            lbl1.Location = new Point(632, 240);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 20);
            lbl1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 583);
            Controls.Add(lbl1);
            Controls.Add(pictureBox1);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private PictureBox pictureBox1;
        private Label lbl1;
    }
}