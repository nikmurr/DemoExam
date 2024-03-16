namespace LopushokModule
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.picture;
            pictureBox1.InitialImage = Properties.Resources.picture;
            pictureBox1.Location = new Point(13, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 39);
            label1.TabIndex = 1;
            label1.Text = "Тип продукта";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Location = new Point(160, 15);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(337, 39);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gabriola", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 39);
            label2.TabIndex = 2;
            label2.Text = "|";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(163, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 39);
            label3.TabIndex = 3;
            label3.Text = "Название продукта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(160, 49);
            label4.Name = "label4";
            label4.Size = new Size(70, 35);
            label4.TabIndex = 4;
            label4.Text = "Артикул";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(697, 84);
            label5.Name = "label5";
            label5.Size = new Size(145, 119);
            label5.TabIndex = 4;
            label5.Text = "Стоимость";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(163, 84);
            label6.Name = "label6";
            label6.Size = new Size(564, 107);
            label6.TabIndex = 5;
            label6.Text = "Материалы";
            label6.Click += label6_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "UserControl1";
            Size = new Size(861, 218);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
