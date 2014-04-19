namespace Board
{
    partial class BoardTestUI
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
            this.boardPanel1 = new Board.BoardPanel();
            this.SuspendLayout();
            // 
            // boardPanel1
            // 
            this.boardPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boardPanel1.Location = new System.Drawing.Point(12, 12);
            this.boardPanel1.Name = "boardPanel1";
            this.boardPanel1.Size = new System.Drawing.Size(545, 410);
            this.boardPanel1.TabIndex = 0;
            this.boardPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel1_Paint);
            // 
            // BoardTestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 434);
            this.Controls.Add(this.boardPanel1);
            this.Name = "BoardTestUI";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private BoardPanel boardPanel1;
    }
}