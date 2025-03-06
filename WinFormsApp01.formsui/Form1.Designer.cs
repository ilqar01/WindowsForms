namespace WinFormsApp01.formsui
{
    partial class PendingToInprocess
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPending = new System.Windows.Forms.ComboBox();
            this.cbxInProcess = new System.Windows.Forms.ComboBox();
            this.cbxDone = new System.Windows.Forms.ComboBox();
            this.btnPendingToProcess = new System.Windows.Forms.Button();
            this.BtnProcessToPending = new System.Windows.Forms.Button();
            this.btnDoneToProcess = new System.Windows.Forms.Button();
            this.btnProcessToDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "To do list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pending";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(305, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "In Process";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(588, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Done";
            // 
            // cbxPending
            // 
            this.cbxPending.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxPending.FormattingEnabled = true;
            this.cbxPending.Items.AddRange(new object[] {
            "Hey",
            "Whats up",
            "some notes"});
            this.cbxPending.Location = new System.Drawing.Point(45, 200);
            this.cbxPending.Name = "cbxPending";
            this.cbxPending.Size = new System.Drawing.Size(151, 255);
            this.cbxPending.TabIndex = 4;
            this.cbxPending.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbxPending_PreviewKeyDown);
            // 
            // cbxInProcess
            // 
            this.cbxInProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxInProcess.FormattingEnabled = true;
            this.cbxInProcess.Location = new System.Drawing.Point(300, 200);
            this.cbxInProcess.Name = "cbxInProcess";
            this.cbxInProcess.Size = new System.Drawing.Size(151, 255);
            this.cbxInProcess.TabIndex = 5;
            this.cbxInProcess.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbxInProcess_PreviewKeyDown);
            // 
            // cbxDone
            // 
            this.cbxDone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxDone.FormattingEnabled = true;
            this.cbxDone.Location = new System.Drawing.Point(564, 200);
            this.cbxDone.Name = "cbxDone";
            this.cbxDone.Size = new System.Drawing.Size(151, 255);
            this.cbxDone.TabIndex = 6;
            this.cbxDone.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbxDone_PreviewKeyDown);
            // 
            // btnPendingToProcess
            // 
            this.btnPendingToProcess.Location = new System.Drawing.Point(216, 256);
            this.btnPendingToProcess.Name = "btnPendingToProcess";
            this.btnPendingToProcess.Size = new System.Drawing.Size(65, 26);
            this.btnPendingToProcess.TabIndex = 7;
            this.btnPendingToProcess.Text = "<<";
            this.btnPendingToProcess.UseVisualStyleBackColor = true;
            this.btnPendingToProcess.Click += new System.EventHandler(this.btnPendingToProcess_Click);
            // 
            // BtnProcessToPending
            // 
            this.BtnProcessToPending.Location = new System.Drawing.Point(216, 322);
            this.BtnProcessToPending.Name = "BtnProcessToPending";
            this.BtnProcessToPending.Size = new System.Drawing.Size(65, 26);
            this.BtnProcessToPending.TabIndex = 8;
            this.BtnProcessToPending.Text = ">>";
            this.BtnProcessToPending.UseVisualStyleBackColor = true;
            this.BtnProcessToPending.Click += new System.EventHandler(this.BtnProcessToPending_Click);
            // 
            // btnDoneToProcess
            // 
            this.btnDoneToProcess.Location = new System.Drawing.Point(477, 322);
            this.btnDoneToProcess.Name = "btnDoneToProcess";
            this.btnDoneToProcess.Size = new System.Drawing.Size(65, 26);
            this.btnDoneToProcess.TabIndex = 10;
            this.btnDoneToProcess.Text = ">>";
            this.btnDoneToProcess.UseVisualStyleBackColor = true;
            this.btnDoneToProcess.Click += new System.EventHandler(this.btnDoneToProcess_Click);
            // 
            // btnProcessToDone
            // 
            this.btnProcessToDone.Location = new System.Drawing.Point(477, 256);
            this.btnProcessToDone.Name = "btnProcessToDone";
            this.btnProcessToDone.Size = new System.Drawing.Size(65, 26);
            this.btnProcessToDone.TabIndex = 9;
            this.btnProcessToDone.Text = "<<";
            this.btnProcessToDone.UseVisualStyleBackColor = true;
            this.btnProcessToDone.Click += new System.EventHandler(this.btnProcessToDone_Click);
            // 
            // PendingToInprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 507);
            this.Controls.Add(this.btnDoneToProcess);
            this.Controls.Add(this.btnProcessToDone);
            this.Controls.Add(this.BtnProcessToPending);
            this.Controls.Add(this.btnPendingToProcess);
            this.Controls.Add(this.cbxDone);
            this.Controls.Add(this.cbxInProcess);
            this.Controls.Add(this.cbxPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PendingToInprocess";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnPendingToProcess;
        private ComboBox cbxDone;
        private ComboBox cbxInProcess;
        private ComboBox cbxPending;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnProcessToPending;
        private Button btnDoneToProcess;
        private Button btnProcessToDone;
    }
}