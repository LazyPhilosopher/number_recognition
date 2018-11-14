namespace MNIST_NeuronNetwork
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
            this.LogBox = new System.Windows.Forms.TextBox();
            this.LookWindow = new System.Windows.Forms.PictureBox();
            this.MNIST_BMP_button = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.ManualQueryButton = new System.Windows.Forms.Button();
            this.percent_box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EpochBox = new System.Windows.Forms.TextBox();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AutoQueryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LookWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percent_box)).BeginInit();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.Black;
            this.LogBox.ForeColor = System.Drawing.Color.Green;
            this.LogBox.Location = new System.Drawing.Point(401, 24);
            this.LogBox.Margin = new System.Windows.Forms.Padding(15);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(543, 700);
            this.LogBox.TabIndex = 0;
            // 
            // LookWindow
            // 
            this.LookWindow.BackColor = System.Drawing.Color.White;
            this.LookWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LookWindow.Location = new System.Drawing.Point(99, 47);
            this.LookWindow.Margin = new System.Windows.Forms.Padding(15);
            this.LookWindow.Name = "LookWindow";
            this.LookWindow.Size = new System.Drawing.Size(200, 200);
            this.LookWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LookWindow.TabIndex = 1;
            this.LookWindow.TabStop = false;
            // 
            // MNIST_BMP_button
            // 
            this.MNIST_BMP_button.BackColor = System.Drawing.Color.Teal;
            this.MNIST_BMP_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MNIST_BMP_button.ForeColor = System.Drawing.Color.White;
            this.MNIST_BMP_button.Location = new System.Drawing.Point(24, 277);
            this.MNIST_BMP_button.Margin = new System.Windows.Forms.Padding(15);
            this.MNIST_BMP_button.Name = "MNIST_BMP_button";
            this.MNIST_BMP_button.Size = new System.Drawing.Size(350, 67);
            this.MNIST_BMP_button.TabIndex = 2;
            this.MNIST_BMP_button.Text = "MNIST to .bmp";
            this.MNIST_BMP_button.UseVisualStyleBackColor = false;
            this.MNIST_BMP_button.Click += new System.EventHandler(this.MNIST_BMP_button_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.BackColor = System.Drawing.Color.Red;
            this.TrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainButton.ForeColor = System.Drawing.Color.White;
            this.TrainButton.Location = new System.Drawing.Point(24, 463);
            this.TrainButton.Margin = new System.Windows.Forms.Padding(15);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(347, 67);
            this.TrainButton.TabIndex = 3;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = false;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // ManualQueryButton
            // 
            this.ManualQueryButton.BackColor = System.Drawing.Color.Teal;
            this.ManualQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManualQueryButton.ForeColor = System.Drawing.Color.White;
            this.ManualQueryButton.Location = new System.Drawing.Point(27, 657);
            this.ManualQueryButton.Margin = new System.Windows.Forms.Padding(15);
            this.ManualQueryButton.Name = "ManualQueryButton";
            this.ManualQueryButton.Size = new System.Drawing.Size(347, 67);
            this.ManualQueryButton.TabIndex = 5;
            this.ManualQueryButton.Text = "Manual Query";
            this.ManualQueryButton.UseVisualStyleBackColor = false;
            this.ManualQueryButton.Click += new System.EventHandler(this.ManualQueryButton_Click);
            // 
            // percent_box
            // 
            this.percent_box.BackColor = System.Drawing.Color.Black;
            this.percent_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percent_box.Location = new System.Drawing.Point(24, 754);
            this.percent_box.Margin = new System.Windows.Forms.Padding(15);
            this.percent_box.Name = "percent_box";
            this.percent_box.Size = new System.Drawing.Size(748, 150);
            this.percent_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.percent_box.TabIndex = 7;
            this.percent_box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(21, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Epochs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(199, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Learn Index:";
            // 
            // EpochBox
            // 
            this.EpochBox.Location = new System.Drawing.Point(27, 407);
            this.EpochBox.Name = "EpochBox";
            this.EpochBox.Size = new System.Drawing.Size(166, 38);
            this.EpochBox.TabIndex = 10;
            this.EpochBox.Text = "100";
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(205, 407);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(166, 38);
            this.IndexBox.TabIndex = 11;
            this.IndexBox.Text = "0,3";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ErrorLabel.Location = new System.Drawing.Point(790, 848);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 32);
            this.ErrorLabel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(790, 754);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 64);
            this.label3.TabIndex = 13;
            this.label3.Text = "Error \r\npercentage:";
            // 
            // AutoQueryButton
            // 
            this.AutoQueryButton.BackColor = System.Drawing.Color.Teal;
            this.AutoQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoQueryButton.ForeColor = System.Drawing.Color.White;
            this.AutoQueryButton.Location = new System.Drawing.Point(27, 548);
            this.AutoQueryButton.Name = "AutoQueryButton";
            this.AutoQueryButton.Size = new System.Drawing.Size(347, 67);
            this.AutoQueryButton.TabIndex = 14;
            this.AutoQueryButton.Text = "Auto Query";
            this.AutoQueryButton.UseVisualStyleBackColor = false;
            this.AutoQueryButton.Click += new System.EventHandler(this.AutoQueryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(968, 912);
            this.Controls.Add(this.AutoQueryButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.EpochBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LookWindow);
            this.Controls.Add(this.percent_box);
            this.Controls.Add(this.ManualQueryButton);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.MNIST_BMP_button);
            this.Controls.Add(this.LogBox);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LookWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percent_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.PictureBox LookWindow;
        private System.Windows.Forms.Button MNIST_BMP_button;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Button ManualQueryButton;
        private System.Windows.Forms.PictureBox percent_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EpochBox;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AutoQueryButton;
    }
}

