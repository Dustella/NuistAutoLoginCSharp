namespace NuistAutoLogin
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.CarrierChoose = new System.Windows.Forms.ComboBox();
            this.Remember = new System.Windows.Forms.CheckBox();
            this.FormLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CarrierLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.FormLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(12, 434);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(64, 16);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP：未知";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.IPLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(3, 235);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(194, 42);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "登陆";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(3, 23);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(194, 22);
            this.UsernameInput.TabIndex = 2;
            this.UsernameInput.TextChanged += new System.EventHandler(this.UsernameInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(3, 91);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(194, 22);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.UseSystemPasswordChar = true;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // CarrierChoose
            // 
            this.CarrierChoose.FormattingEnabled = true;
            this.CarrierChoose.Location = new System.Drawing.Point(3, 160);
            this.CarrierChoose.Name = "CarrierChoose";
            this.CarrierChoose.Size = new System.Drawing.Size(194, 24);
            this.CarrierChoose.TabIndex = 4;
            // 
            // Remember
            // 
            this.Remember.AutoSize = true;
            this.Remember.Location = new System.Drawing.Point(3, 199);
            this.Remember.Name = "Remember";
            this.Remember.Size = new System.Drawing.Size(89, 20);
            this.Remember.TabIndex = 5;
            this.Remember.Text = "记住密码";
            this.Remember.UseVisualStyleBackColor = true;
            this.Remember.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormLayout
            // 
            this.FormLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormLayout.ColumnCount = 1;
            this.FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormLayout.Controls.Add(this.LoginButton, 0, 7);
            this.FormLayout.Controls.Add(this.Remember, 0, 6);
            this.FormLayout.Controls.Add(this.PasswordInput, 0, 3);
            this.FormLayout.Controls.Add(this.CarrierChoose, 0, 5);
            this.FormLayout.Controls.Add(this.UsernameInput, 0, 1);
            this.FormLayout.Controls.Add(this.UsernameLabel, 0, 0);
            this.FormLayout.Controls.Add(this.PasswordLabel, 0, 2);
            this.FormLayout.Controls.Add(this.CarrierLabel, 0, 4);
            this.FormLayout.Location = new System.Drawing.Point(115, 80);
            this.FormLayout.Name = "FormLayout";
            this.FormLayout.RowCount = 9;
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.FormLayout.Size = new System.Drawing.Size(200, 328);
            this.FormLayout.TabIndex = 6;
            this.FormLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(3, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(52, 16);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "用户名";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 66);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(37, 16);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "密码";
            // 
            // CarrierLabel
            // 
            this.CarrierLabel.AutoSize = true;
            this.CarrierLabel.Location = new System.Drawing.Point(3, 137);
            this.CarrierLabel.Name = "CarrierLabel";
            this.CarrierLabel.Size = new System.Drawing.Size(52, 16);
            this.CarrierLabel.TabIndex = 8;
            this.CarrierLabel.Text = "运营商";
            this.CarrierLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(174, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(73, 29);
            this.Title.TabIndex = 7;
            this.Title.Text = "Login";
            this.Title.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 459);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.FormLayout);
            this.Controls.Add(this.IPLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "NuistAutoLogin";
            this.FormLayout.ResumeLayout(false);
            this.FormLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.ComboBox CarrierChoose;
        private System.Windows.Forms.CheckBox Remember;
        private System.Windows.Forms.TableLayoutPanel FormLayout;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label CarrierLabel;
    }
}

