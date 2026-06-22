namespace application
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
            outputRichtextbox = new RichTextBox();
            minButton = new Button();
            maxButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // outputRichtextbox
            // 
            outputRichtextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputRichtextbox.BackColor = Color.Black;
            outputRichtextbox.BorderStyle = BorderStyle.None;
            outputRichtextbox.ForeColor = Color.Lime;
            outputRichtextbox.Location = new Point(465, 126);
            outputRichtextbox.Name = "outputRichtextbox";
            outputRichtextbox.ReadOnly = true;
            outputRichtextbox.Size = new Size(323, 302);
            outputRichtextbox.TabIndex = 0;
            outputRichtextbox.Text = "";
            outputRichtextbox.LinkClicked += richTextBox1_LinkClicked;
            // 
            // minButton
            // 
            minButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minButton.BackColor = Color.Black;
            minButton.FlatStyle = FlatStyle.Flat;
            minButton.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minButton.ForeColor = Color.Lime;
            minButton.Location = new Point(725, 0);
            minButton.Name = "minButton";
            minButton.Size = new Size(25, 25);
            minButton.TabIndex = 1;
            minButton.Text = "—";
            minButton.UseVisualStyleBackColor = false;
            minButton.Click += minButton_Click;
            // 
            // maxButton
            // 
            maxButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxButton.BackColor = Color.Black;
            maxButton.FlatStyle = FlatStyle.Flat;
            maxButton.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maxButton.ForeColor = Color.Lime;
            maxButton.Location = new Point(750, 0);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(25, 25);
            maxButton.TabIndex = 2;
            maxButton.Text = "⧠";
            maxButton.UseVisualStyleBackColor = false;
            maxButton.Click += maxButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackColor = Color.Black;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Lucida Console", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.Lime;
            closeButton.Location = new Point(775, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 25);
            closeButton.TabIndex = 3;
            closeButton.Text = "╳";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 440);
            Controls.Add(closeButton);
            Controls.Add(maxButton);
            Controls.Add(minButton);
            Controls.Add(outputRichtextbox);
            Font = new Font("Lucida Console", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            MouseDoubleClick += Form1_MouseDoubleClick;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox outputRichtextbox;
        private Button minButton;
        private Button maxButton;
        private Button closeButton;
    }
}
