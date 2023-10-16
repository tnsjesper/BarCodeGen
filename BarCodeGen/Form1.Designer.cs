namespace BarCodeGen
{
    partial class BarCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarCodeGenerator));
            BTNGenerate = new Button();
            PicBoxBarCode = new PictureBox();
            label1 = new Label();
            TextBox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxBarCode).BeginInit();
            SuspendLayout();
            // 
            // BTNGenerate
            // 
            BTNGenerate.Location = new Point(239, 500);
            BTNGenerate.Name = "BTNGenerate";
            BTNGenerate.Size = new Size(112, 65);
            BTNGenerate.TabIndex = 0;
            BTNGenerate.Text = "Generate";
            BTNGenerate.UseVisualStyleBackColor = true;
            BTNGenerate.Click += BTNGenerate_Click;
            // 
            // PicBoxBarCode
            // 
            PicBoxBarCode.Location = new Point(12, 6);
            PicBoxBarCode.Name = "PicBoxBarCode";
            PicBoxBarCode.Size = new Size(460, 440);
            PicBoxBarCode.TabIndex = 1;
            PicBoxBarCode.TabStop = false;
            PicBoxBarCode.Click += PicBoxBarCode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 458);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Barcode:";
            label1.Click += label1_Click;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(71, 455);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(388, 23);
            TextBox.TabIndex = 4;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(117, 500);
            button1.Name = "button1";
            button1.Size = new Size(116, 65);
            button1.TabIndex = 5;
            button1.Text = "Save (PNG)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BarCodeGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 604);
            Controls.Add(button1);
            Controls.Add(TextBox);
            Controls.Add(label1);
            Controls.Add(PicBoxBarCode);
            Controls.Add(BTNGenerate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BarCodeGenerator";
            ShowIcon = false;
            Text = "BarCode Generator";
            ((System.ComponentModel.ISupportInitialize)PicBoxBarCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNGenerate;
        private PictureBox PicBoxBarCode;
        private Label label1;
        private TextBox TextBox;
        private Button button1;
    }
}