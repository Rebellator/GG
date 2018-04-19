namespace Oskars
{
    partial class FormAdd
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNominations = new System.Windows.Forms.TextBox();
            this.textBoxOscars = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNominations = new System.Windows.Forms.Label();
            this.labelOscars = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxNominations
            // 
            this.textBoxNominations.Location = new System.Drawing.Point(118, 29);
            this.textBoxNominations.Name = "textBoxNominations";
            this.textBoxNominations.Size = new System.Drawing.Size(100, 20);
            this.textBoxNominations.TabIndex = 1;
            // 
            // textBoxOscars
            // 
            this.textBoxOscars.Location = new System.Drawing.Point(224, 29);
            this.textBoxOscars.Name = "textBoxOscars";
            this.textBoxOscars.Size = new System.Drawing.Size(100, 20);
            this.textBoxOscars.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelNominations
            // 
            this.labelNominations.AutoSize = true;
            this.labelNominations.Location = new System.Drawing.Point(115, 9);
            this.labelNominations.Name = "labelNominations";
            this.labelNominations.Size = new System.Drawing.Size(65, 13);
            this.labelNominations.TabIndex = 4;
            this.labelNominations.Text = "Nominations";
            // 
            // labelOscars
            // 
            this.labelOscars.AutoSize = true;
            this.labelOscars.Location = new System.Drawing.Point(221, 9);
            this.labelOscars.Name = "labelOscars";
            this.labelOscars.Size = new System.Drawing.Size(40, 13);
            this.labelOscars.TabIndex = 5;
            this.labelOscars.Text = "Oscars";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonSave.Location = new System.Drawing.Point(249, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Tomato;
            this.buttonCancel.Location = new System.Drawing.Point(168, 55);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 93);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelOscars);
            this.Controls.Add(this.labelNominations);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxOscars);
            this.Controls.Add(this.textBoxNominations);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNominations;
        private System.Windows.Forms.TextBox textBoxOscars;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNominations;
        private System.Windows.Forms.Label labelOscars;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}