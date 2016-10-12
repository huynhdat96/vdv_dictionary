namespace vdv_dictionary
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
            this.click_here = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // click_here
            // 
            this.click_here.Location = new System.Drawing.Point(21, 12);
            this.click_here.Name = "click_here";
            this.click_here.Size = new System.Drawing.Size(129, 50);
            this.click_here.TabIndex = 0;
            this.click_here.Text = "Click Here";
            this.click_here.UseVisualStyleBackColor = true;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(21, 68);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(604, 26);
            this.enter.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 338);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.click_here);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click_here;
        private System.Windows.Forms.TextBox enter;

    }
}

