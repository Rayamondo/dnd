namespace Layout_Test
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
            this.flwCharButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAddChar = new System.Windows.Forms.TextBox();
            this.buChar_add = new System.Windows.Forms.Button();
            this.buChar_showAll = new System.Windows.Forms.Button();
            this.flwCharScreen = new System.Windows.Forms.FlowLayoutPanel();
            this.flwCharButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwCharButtons
            // 
            this.flwCharButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flwCharButtons.Controls.Add(this.txtAddChar);
            this.flwCharButtons.Controls.Add(this.buChar_add);
            this.flwCharButtons.Controls.Add(this.buChar_showAll);
            this.flwCharButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwCharButtons.Location = new System.Drawing.Point(24, 23);
            this.flwCharButtons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flwCharButtons.Name = "flwCharButtons";
            this.flwCharButtons.Size = new System.Drawing.Size(404, 1044);
            this.flwCharButtons.TabIndex = 0;
            // 
            // txtAddChar
            // 
            this.txtAddChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddChar.Location = new System.Drawing.Point(6, 6);
            this.txtAddChar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddChar.Name = "txtAddChar";
            this.txtAddChar.Size = new System.Drawing.Size(386, 37);
            this.txtAddChar.TabIndex = 1;
            this.txtAddChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddChar_KeyDown);
            // 
            // buChar_add
            // 
            this.buChar_add.Location = new System.Drawing.Point(6, 55);
            this.buChar_add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buChar_add.Name = "buChar_add";
            this.buChar_add.Size = new System.Drawing.Size(390, 63);
            this.buChar_add.TabIndex = 0;
            this.buChar_add.Text = "Add Character...";
            this.buChar_add.UseVisualStyleBackColor = true;
            this.buChar_add.Click += new System.EventHandler(this.buChar_add_Click);
            // 
            // buChar_showAll
            // 
            this.buChar_showAll.Location = new System.Drawing.Point(6, 130);
            this.buChar_showAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buChar_showAll.Name = "buChar_showAll";
            this.buChar_showAll.Size = new System.Drawing.Size(390, 63);
            this.buChar_showAll.TabIndex = 2;
            this.buChar_showAll.Text = "Show all...";
            this.buChar_showAll.UseVisualStyleBackColor = true;
            this.buChar_showAll.Click += new System.EventHandler(this.buChar_showAll_Click);
            // 
            // flwCharScreen
            // 
            this.flwCharScreen.Location = new System.Drawing.Point(434, 23);
            this.flwCharScreen.Margin = new System.Windows.Forms.Padding(0);
            this.flwCharScreen.Name = "flwCharScreen";
            this.flwCharScreen.Size = new System.Drawing.Size(1204, 1044);
            this.flwCharScreen.TabIndex = 1;
            this.flwCharScreen.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1094);
            this.Controls.Add(this.flwCharScreen);
            this.Controls.Add(this.flwCharButtons);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "DND Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flwCharButtons.ResumeLayout(false);
            this.flwCharButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwCharButtons;
        private System.Windows.Forms.Button buChar_add;
        private System.Windows.Forms.TextBox txtAddChar;
        private System.Windows.Forms.Button buChar_showAll;
        private System.Windows.Forms.FlowLayoutPanel flwCharScreen;
    }
}

