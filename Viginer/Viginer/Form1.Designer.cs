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
            this.DecodeVig = new System.Windows.Forms.Button();
            this.Pseudo = new System.Windows.Forms.RadioButton();
            this.TextForCoderVig = new System.Windows.Forms.RichTextBox();
            this.Standart = new System.Windows.Forms.RadioButton();
            this.KeyVigTextBox = new System.Windows.Forms.TextBox();
            this.EncodeVig = new System.Windows.Forms.Button();
            this.HafTab = new System.Windows.Forms.TabPage();
            this.DecodeHaf = new System.Windows.Forms.Button();
            this.TextForCoderHaf = new System.Windows.Forms.RichTextBox();
            this.EncodeHaf = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.VigеnerTab.SuspendLayout();
            this.HafTab.SuspendLayout();
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
            this.VigеnerTab.Controls.Add(this.DecodeVig);
            this.VigеnerTab.Controls.Add(this.Pseudo);
            this.VigеnerTab.Controls.Add(this.TextForCoderVig);
            this.VigеnerTab.Controls.Add(this.Standart);
            this.VigеnerTab.Controls.Add(this.KeyVigTextBox);
            this.VigеnerTab.Controls.Add(this.EncodeVig);
            this.VigеnerTab.Location = new System.Drawing.Point(4, 22);
            this.VigеnerTab.Name = "VigеnerTab";
            this.VigеnerTab.Padding = new System.Windows.Forms.Padding(3);
            this.VigеnerTab.Size = new System.Drawing.Size(297, 162);
            this.VigеnerTab.TabIndex = 0;
            this.VigеnerTab.Text = "Виженер";
            // 
            // DecodeVig
            // 
            this.DecodeVig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DecodeVig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DecodeVig.Location = new System.Drawing.Point(57, 6);
            this.DecodeVig.Name = "DecodeVig";
            this.DecodeVig.Size = new System.Drawing.Size(48, 43);
            this.DecodeVig.TabIndex = 6;
            this.DecodeVig.Text = "Расшифров.";
            this.DecodeVig.UseVisualStyleBackColor = false;
            this.DecodeVig.Click += new System.EventHandler(this.Decode_Click);
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
            this.TextForCoderVig.Location = new System.Drawing.Point(3, 55);
            this.TextForCoderVig.Name = "TextForCoderVig";
            this.TextForCoderVig.Size = new System.Drawing.Size(291, 101);
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
            // KeyVigTextBox
            // 
            this.KeyVigTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyVigTextBox.Location = new System.Drawing.Point(113, 6);
            this.KeyVigTextBox.Name = "KeyVigTextBox";
            this.KeyVigTextBox.Size = new System.Drawing.Size(178, 20);
            this.KeyVigTextBox.TabIndex = 2;
            this.KeyVigTextBox.Text = "Ключ";
            // 
            // EncodeVig
            // 
            this.EncodeVig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EncodeVig.Font = new System.Drawing.Font("Mishmash BRK", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodeVig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EncodeVig.Location = new System.Drawing.Point(3, 6);
            this.EncodeVig.Name = "EncodeVig";
            this.EncodeVig.Size = new System.Drawing.Size(48, 43);
            this.EncodeVig.TabIndex = 0;
            this.EncodeVig.Text = "Зашифров.";
            this.EncodeVig.UseVisualStyleBackColor = false;
            this.EncodeVig.Click += new System.EventHandler(this.Encode_Click);
            // 
            // HafTab
            // 
            this.HafTab.BackColor = System.Drawing.Color.NavajoWhite;
            this.HafTab.Controls.Add(this.DecodeHaf);
            this.HafTab.Controls.Add(this.TextForCoderHaf);
            this.HafTab.Controls.Add(this.EncodeHaf);
            this.HafTab.Location = new System.Drawing.Point(4, 22);
            this.HafTab.Name = "HafTab";
            this.HafTab.Padding = new System.Windows.Forms.Padding(3);
            this.HafTab.Size = new System.Drawing.Size(297, 162);
            this.HafTab.TabIndex = 1;
            this.HafTab.Text = "Хаффман";
            // 
            // DecodeHaf
            // 
            this.DecodeHaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DecodeHaf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DecodeHaf.Location = new System.Drawing.Point(57, 6);
            this.DecodeHaf.Name = "DecodeHaf";
            this.DecodeHaf.Size = new System.Drawing.Size(48, 43);
            this.DecodeHaf.TabIndex = 12;
            this.DecodeHaf.Text = "Расшифров.";
            this.DecodeHaf.UseVisualStyleBackColor = false;
            this.DecodeHaf.Click += new System.EventHandler(this.DecodeHaf_Click);
            // 
            // TextForCoderHaf
            // 
            this.TextForCoderHaf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextForCoderHaf.Location = new System.Drawing.Point(3, 55);
            this.TextForCoderHaf.Name = "TextForCoderHaf";
            this.TextForCoderHaf.Size = new System.Drawing.Size(291, 101);
            this.TextForCoderHaf.TabIndex = 10;
            this.TextForCoderHaf.Text = "Текст";
            // 
            // EncodeHaf
            // 
            this.EncodeHaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EncodeHaf.Font = new System.Drawing.Font("Mishmash BRK", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodeHaf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EncodeHaf.Location = new System.Drawing.Point(3, 6);
            this.EncodeHaf.Name = "EncodeHaf";
            this.EncodeHaf.Size = new System.Drawing.Size(48, 43);
            this.EncodeHaf.TabIndex = 7;
            this.EncodeHaf.Text = "Зашифров.";
            this.EncodeHaf.UseVisualStyleBackColor = false;
            this.EncodeHaf.Click += new System.EventHandler(this.EncodeHaf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(305, 188);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Кодирование";
            this.Tabs.ResumeLayout(false);
            this.VigеnerTab.ResumeLayout(false);
            this.VigеnerTab.PerformLayout();
            this.HafTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon NotifyCoder;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage VigеnerTab;
        private System.Windows.Forms.RichTextBox TextForCoderVig;
        private System.Windows.Forms.RadioButton Standart;
        private System.Windows.Forms.TextBox KeyVigTextBox;
        private System.Windows.Forms.Button EncodeVig;
        private System.Windows.Forms.RadioButton Pseudo;
        private System.Windows.Forms.Button DecodeVig;
        private System.Windows.Forms.TabPage HafTab;
        private System.Windows.Forms.Button DecodeHaf;
        private System.Windows.Forms.RichTextBox TextForCoderHaf;
        private System.Windows.Forms.Button EncodeHaf;
    }
}

