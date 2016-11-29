namespace Coders
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NotifyCoder = new System.Windows.Forms.NotifyIcon(this.components);
            this.Tabs = new System.Windows.Forms.TabControl();
            this.VigеnerTab = new System.Windows.Forms.TabPage();
            this.Decode = new System.Windows.Forms.Button();
            this.Pseudo = new System.Windows.Forms.RadioButton();
            this.TextForCoderVig = new System.Windows.Forms.RichTextBox();
            this.Standart = new System.Windows.Forms.RadioButton();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.Encode = new System.Windows.Forms.Button();
            this.HafTab = new System.Windows.Forms.TabPage();
            this.Tabs.SuspendLayout();
            this.VigеnerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyCoder
            // 
            this.NotifyCoder.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyCoder.Icon")));
            this.NotifyCoder.Text = "Coder";
            this.NotifyCoder.Visible = true;
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.VigеnerTab);
            this.Tabs.Controls.Add(this.HafTab);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(305, 188);
            this.Tabs.TabIndex = 1;
            // 
            // VigеnerTab
            // 
            this.VigеnerTab.BackColor = System.Drawing.Color.PeachPuff;
            this.VigеnerTab.Controls.Add(this.Decode);
            this.VigеnerTab.Controls.Add(this.Pseudo);
            this.VigеnerTab.Controls.Add(this.TextForCoderVig);
            this.VigеnerTab.Controls.Add(this.Standart);
            this.VigеnerTab.Controls.Add(this.KeyTextBox);
            this.VigеnerTab.Controls.Add(this.Encode);
            this.VigеnerTab.Location = new System.Drawing.Point(4, 22);
            this.VigеnerTab.Name = "VigеnerTab";
            this.VigеnerTab.Padding = new System.Windows.Forms.Padding(3);
            this.VigеnerTab.Size = new System.Drawing.Size(297, 162);
            this.VigеnerTab.TabIndex = 0;
            this.VigеnerTab.Text = "Виженер";
            // 
            // Decode
            // 
            this.Decode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Decode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Decode.Location = new System.Drawing.Point(59, 6);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(48, 43);
            this.Decode.TabIndex = 6;
            this.Decode.Text = "Расшифров.";
            this.Decode.UseVisualStyleBackColor = false;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Pseudo
            // 
            this.Pseudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pseudo.AutoSize = true;
            this.Pseudo.Location = new System.Drawing.Point(204, 32);
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.Size = new System.Drawing.Size(88, 17);
            this.Pseudo.TabIndex = 5;
            this.Pseudo.TabStop = true;
            this.Pseudo.Text = "Псевдослуч.";
            this.Pseudo.UseVisualStyleBackColor = true;
            this.Pseudo.CheckedChanged += new System.EventHandler(this.Standart_CheckedChanged);
            // 
            // TextForCoderVig
            // 
            this.TextForCoderVig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextForCoderVig.Location = new System.Drawing.Point(8, 55);
            this.TextForCoderVig.Name = "TextForCoderVig";
            this.TextForCoderVig.Size = new System.Drawing.Size(281, 96);
            this.TextForCoderVig.TabIndex = 4;
            this.TextForCoderVig.Text = "Текст";
            // 
            // Standart
            // 
            this.Standart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Standart.AutoSize = true;
            this.Standart.Location = new System.Drawing.Point(113, 32);
            this.Standart.Name = "Standart";
            this.Standart.Size = new System.Drawing.Size(64, 17);
            this.Standart.TabIndex = 3;
            this.Standart.TabStop = true;
            this.Standart.Text = "Обычно";
            this.Standart.UseVisualStyleBackColor = true;
            this.Standart.CheckedChanged += new System.EventHandler(this.Standart_CheckedChanged);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyTextBox.Location = new System.Drawing.Point(113, 6);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(176, 20);
            this.KeyTextBox.TabIndex = 2;
            this.KeyTextBox.Text = "Ключ";
            // 
            // Encode
            // 
            this.Encode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Encode.Font = new System.Drawing.Font("Mishmash BRK", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Encode.Location = new System.Drawing.Point(8, 6);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(48, 43);
            this.Encode.TabIndex = 0;
            this.Encode.Text = "Зашифров.";
            this.Encode.UseVisualStyleBackColor = false;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // HafTab
            // 
            this.HafTab.Location = new System.Drawing.Point(4, 22);
            this.HafTab.Name = "HafTab";
            this.HafTab.Padding = new System.Windows.Forms.Padding(3);
            this.HafTab.Size = new System.Drawing.Size(297, 162);
            this.HafTab.TabIndex = 1;
            this.HafTab.Text = "Хафман";
            this.HafTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 188);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Кодирование";
            this.Tabs.ResumeLayout(false);
            this.VigеnerTab.ResumeLayout(false);
            this.VigеnerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon NotifyCoder;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage VigеnerTab;
        private System.Windows.Forms.RichTextBox TextForCoderVig;
        private System.Windows.Forms.RadioButton Standart;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.RadioButton Pseudo;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.TabPage HafTab;
    }
}

