
namespace ARMSWinClient
{
    partial class frmCreditCardList
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
            this.btnListAllCreditCards = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCreditCardList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListAllCreditCards
            // 
            this.btnListAllCreditCards.Location = new System.Drawing.Point(12, 112);
            this.btnListAllCreditCards.Name = "btnListAllCreditCards";
            this.btnListAllCreditCards.Size = new System.Drawing.Size(145, 27);
            this.btnListAllCreditCards.TabIndex = 0;
            this.btnListAllCreditCards.Text = "List All Credit Cards";
            this.btnListAllCreditCards.UseVisualStyleBackColor = true;
            this.btnListAllCreditCards.Click += new System.EventHandler(this.btnListAllCreditCards_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "List Credit Card Screen";
            // 
            // lblSTitle
            // 
            this.lblSTitle.AutoSize = true;
            this.lblSTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTitle.Location = new System.Drawing.Point(12, 87);
            this.lblSTitle.Name = "lblSTitle";
            this.lblSTitle.Size = new System.Drawing.Size(247, 13);
            this.lblSTitle.TabIndex = 2;
            this.lblSTitle.Text = "Click List All Button to list all Credit Cards:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(640, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvCreditCardList
            // 
            this.dgvCreditCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditCardList.Location = new System.Drawing.Point(19, 166);
            this.dgvCreditCardList.Name = "dgvCreditCardList";
            this.dgvCreditCardList.Size = new System.Drawing.Size(240, 150);
            this.dgvCreditCardList.TabIndex = 4;
            this.dgvCreditCardList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditCardList_CellContentClick);
            // 
            // frmCreditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.dgvCreditCardList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnListAllCreditCards);
            this.Name = "frmCreditCardList";
            this.Text = "Credit Card List";
            this.Load += new System.EventHandler(this.frmCreditCardList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListAllCreditCards;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCreditCardList;
    }
}