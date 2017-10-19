namespace ExternalBase
{
    partial class Menu
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
            this.bhopToggle = new System.Windows.Forms.CheckBox();
            this.triggerToggle = new System.Windows.Forms.CheckBox();
            this.bhopDelay = new System.Windows.Forms.TrackBar();
            this.triggerDelay = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.bhopDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // bhopToggle
            // 
            this.bhopToggle.AutoSize = true;
            this.bhopToggle.Location = new System.Drawing.Point(12, 12);
            this.bhopToggle.Name = "bhopToggle";
            this.bhopToggle.Size = new System.Drawing.Size(74, 17);
            this.bhopToggle.TabIndex = 0;
            this.bhopToggle.Text = "Bunnyhop";
            this.bhopToggle.UseVisualStyleBackColor = true;
            this.bhopToggle.CheckedChanged += new System.EventHandler(this.bhopToggle_CheckedChanged);
            // 
            // triggerToggle
            // 
            this.triggerToggle.AutoSize = true;
            this.triggerToggle.Location = new System.Drawing.Point(12, 77);
            this.triggerToggle.Name = "triggerToggle";
            this.triggerToggle.Size = new System.Drawing.Size(103, 17);
            this.triggerToggle.TabIndex = 1;
            this.triggerToggle.Text = "Triggerbot (ALT)";
            this.triggerToggle.UseVisualStyleBackColor = true;
            this.triggerToggle.CheckedChanged += new System.EventHandler(this.triggerToggle_CheckedChanged);
            // 
            // bhopDelay
            // 
            this.bhopDelay.Location = new System.Drawing.Point(121, 12);
            this.bhopDelay.Maximum = 20;
            this.bhopDelay.Name = "bhopDelay";
            this.bhopDelay.Size = new System.Drawing.Size(137, 45);
            this.bhopDelay.TabIndex = 2;
            this.bhopDelay.Scroll += new System.EventHandler(this.bhopDelay_Scroll);
            // 
            // triggerDelay
            // 
            this.triggerDelay.Location = new System.Drawing.Point(121, 77);
            this.triggerDelay.Maximum = 20;
            this.triggerDelay.Name = "triggerDelay";
            this.triggerDelay.Size = new System.Drawing.Size(137, 45);
            this.triggerDelay.TabIndex = 3;
            this.triggerDelay.Scroll += new System.EventHandler(this.triggerDelay_Scroll);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 133);
            this.Controls.Add(this.triggerDelay);
            this.Controls.Add(this.bhopDelay);
            this.Controls.Add(this.triggerToggle);
            this.Controls.Add(this.bhopToggle);
            this.Name = "Menu";
            this.Text = "pcheeto ";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bhopDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox bhopToggle;
        private System.Windows.Forms.CheckBox triggerToggle;
        private System.Windows.Forms.TrackBar bhopDelay;
        private System.Windows.Forms.TrackBar triggerDelay;
    }
}