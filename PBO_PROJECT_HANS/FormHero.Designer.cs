namespace PBO_PROJECT_HANS
{
    partial class FormHero
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
            this.radioButtonBerseker = new System.Windows.Forms.RadioButton();
            this.radioButtonRaven = new System.Windows.Forms.RadioButton();
            this.radioButtonArcher = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonBerseker
            // 
            this.radioButtonBerseker.AutoSize = true;
            this.radioButtonBerseker.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonBerseker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonBerseker.Image = global::PBO_PROJECT_HANS.Properties.Resources.Berseker;
            this.radioButtonBerseker.Location = new System.Drawing.Point(421, 198);
            this.radioButtonBerseker.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonBerseker.Name = "radioButtonBerseker";
            this.radioButtonBerseker.Size = new System.Drawing.Size(309, 309);
            this.radioButtonBerseker.TabIndex = 0;
            this.radioButtonBerseker.TabStop = true;
            this.radioButtonBerseker.UseVisualStyleBackColor = false;
            this.radioButtonBerseker.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonRaven
            // 
            this.radioButtonRaven.AutoSize = true;
            this.radioButtonRaven.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonRaven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonRaven.Image = global::PBO_PROJECT_HANS.Properties.Resources.Ravenn;
            this.radioButtonRaven.Location = new System.Drawing.Point(837, 203);
            this.radioButtonRaven.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRaven.Name = "radioButtonRaven";
            this.radioButtonRaven.Size = new System.Drawing.Size(227, 305);
            this.radioButtonRaven.TabIndex = 0;
            this.radioButtonRaven.TabStop = true;
            this.radioButtonRaven.UseVisualStyleBackColor = false;
            // 
            // radioButtonArcher
            // 
            this.radioButtonArcher.AutoSize = true;
            this.radioButtonArcher.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonArcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonArcher.Image = global::PBO_PROJECT_HANS.Properties.Resources.Archer;
            this.radioButtonArcher.Location = new System.Drawing.Point(28, 218);
            this.radioButtonArcher.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonArcher.Name = "radioButtonArcher";
            this.radioButtonArcher.Size = new System.Drawing.Size(292, 280);
            this.radioButtonArcher.TabIndex = 0;
            this.radioButtonArcher.TabStop = true;
            this.radioButtonArcher.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::PBO_PROJECT_HANS.Properties.Resources.Play;
            this.button1.Location = new System.Drawing.Point(469, 631);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 65);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBO_PROJECT_HANS.Properties.Resources.BackGroundSelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 762);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonRaven);
            this.Controls.Add(this.radioButtonArcher);
            this.Controls.Add(this.radioButtonBerseker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHero";
            this.Text = "SELECT HERO";
            this.Load += new System.EventHandler(this.FormHero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBerseker;
        private System.Windows.Forms.RadioButton radioButtonRaven;
        private System.Windows.Forms.RadioButton radioButtonArcher;
        private System.Windows.Forms.Button button1;
    }
}