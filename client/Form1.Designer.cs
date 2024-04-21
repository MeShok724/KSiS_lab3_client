namespace Ksis_lab3
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
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.tbPathToSave = new System.Windows.Forms.TextBox();
            this.btnPostFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbGetFilePath = new System.Windows.Forms.TextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbGetFile = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPutNewFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPutFilePath = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbDeleteFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbCopyDestPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCopyFilePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMove = new System.Windows.Forms.Button();
            this.tbMoveDestPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMoveFilePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(20, 40);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(317, 26);
            this.tbFilePath.TabIndex = 0;
            this.tbFilePath.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // tbPathToSave
            // 
            this.tbPathToSave.Location = new System.Drawing.Point(20, 104);
            this.tbPathToSave.Name = "tbPathToSave";
            this.tbPathToSave.Size = new System.Drawing.Size(317, 26);
            this.tbPathToSave.TabIndex = 0;
            this.tbPathToSave.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // btnPostFile
            // 
            this.btnPostFile.Location = new System.Drawing.Point(399, 97);
            this.btnPostFile.Name = "btnPostFile";
            this.btnPostFile.Size = new System.Drawing.Size(99, 41);
            this.btnPostFile.TabIndex = 1;
            this.btnPostFile.Text = "POST file";
            this.btnPostFile.UseVisualStyleBackColor = true;
            this.btnPostFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path to save";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(381, 29);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(126, 37);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tbGetFilePath
            // 
            this.tbGetFilePath.Location = new System.Drawing.Point(22, 57);
            this.tbGetFilePath.Name = "tbGetFilePath";
            this.tbGetFilePath.Size = new System.Drawing.Size(317, 26);
            this.tbGetFilePath.TabIndex = 0;
            this.tbGetFilePath.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(379, 46);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(126, 37);
            this.btnGetFile.TabIndex = 1;
            this.btnGetFile.Text = "GET file";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "File name";
            // 
            // rtbGetFile
            // 
            this.rtbGetFile.Location = new System.Drawing.Point(22, 117);
            this.rtbGetFile.Name = "rtbGetFile";
            this.rtbGetFile.Size = new System.Drawing.Size(485, 112);
            this.rtbGetFile.TabIndex = 3;
            this.rtbGetFile.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnPostFile);
            this.panel1.Controls.Add(this.tbFilePath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPathToSave);
            this.panel1.Controls.Add(this.btnChooseFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(71, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 153);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.rtbGetFile);
            this.panel2.Controls.Add(this.tbGetFilePath);
            this.panel2.Controls.Add(this.btnGetFile);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(71, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 250);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.btnPut);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.tbPutNewFile);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbPutFilePath);
            this.panel3.Location = new System.Drawing.Point(71, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 151);
            this.panel3.TabIndex = 6;
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(399, 96);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(99, 41);
            this.btnPut.TabIndex = 1;
            this.btnPut.Text = "PUT file";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbPutNewFile
            // 
            this.tbPutNewFile.Location = new System.Drawing.Point(20, 38);
            this.tbPutNewFile.Name = "tbPutNewFile";
            this.tbPutNewFile.Size = new System.Drawing.Size(317, 26);
            this.tbPutNewFile.TabIndex = 0;
            this.tbPutNewFile.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name of the file to PUT";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "New file name";
            // 
            // tbPutFilePath
            // 
            this.tbPutFilePath.Location = new System.Drawing.Point(20, 103);
            this.tbPutFilePath.Name = "tbPutFilePath";
            this.tbPutFilePath.Size = new System.Drawing.Size(317, 26);
            this.tbPutFilePath.TabIndex = 0;
            this.tbPutFilePath.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.tbDeleteFileName);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(623, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(532, 100);
            this.panel4.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "DELETE file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbDeleteFileName
            // 
            this.tbDeleteFileName.Location = new System.Drawing.Point(22, 45);
            this.tbDeleteFileName.Name = "tbDeleteFileName";
            this.tbDeleteFileName.Size = new System.Drawing.Size(317, 26);
            this.tbDeleteFileName.TabIndex = 0;
            this.tbDeleteFileName.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(22, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "File to delete";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.btnCopy);
            this.panel5.Controls.Add(this.tbCopyDestPath);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.tbCopyFilePath);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(623, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 147);
            this.panel5.TabIndex = 7;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(381, 40);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(126, 37);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "COPY file";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbCopyDestPath
            // 
            this.tbCopyDestPath.Location = new System.Drawing.Point(22, 106);
            this.tbCopyDestPath.Name = "tbCopyDestPath";
            this.tbCopyDestPath.Size = new System.Drawing.Size(317, 26);
            this.tbCopyDestPath.TabIndex = 0;
            this.tbCopyDestPath.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(22, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Path to copy";
            // 
            // tbCopyFilePath
            // 
            this.tbCopyFilePath.Location = new System.Drawing.Point(22, 45);
            this.tbCopyFilePath.Name = "tbCopyFilePath";
            this.tbCopyFilePath.Size = new System.Drawing.Size(317, 26);
            this.tbCopyFilePath.TabIndex = 0;
            this.tbCopyFilePath.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(22, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "File to copy";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.btnMove);
            this.panel6.Controls.Add(this.tbMoveDestPath);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.tbMoveFilePath);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(623, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(532, 147);
            this.panel6.TabIndex = 7;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(381, 40);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(126, 37);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "MOVE file";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // tbMoveDestPath
            // 
            this.tbMoveDestPath.Location = new System.Drawing.Point(22, 106);
            this.tbMoveDestPath.Name = "tbMoveDestPath";
            this.tbMoveDestPath.Size = new System.Drawing.Size(317, 26);
            this.tbMoveDestPath.TabIndex = 0;
            this.tbMoveDestPath.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(22, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Path to move";
            // 
            // tbMoveFilePath
            // 
            this.tbMoveFilePath.Location = new System.Drawing.Point(22, 45);
            this.tbMoveFilePath.Name = "tbMoveFilePath";
            this.tbMoveFilePath.Size = new System.Drawing.Size(317, 26);
            this.tbMoveFilePath.TabIndex = 0;
            this.tbMoveFilePath.Text = "C:/BSUIR/TI/lab3/new.jpg";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(22, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "File to move";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1328, 1021);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbCopyFilePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCopyDestPath;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox tbMoveDestPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMoveFilePath;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDeleteFileName;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPutNewFile;
        private System.Windows.Forms.TextBox tbPutFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPut;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox tbGetFilePath;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbGetFile;
        private System.Windows.Forms.Button btnGetFile;

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox tbPathToSave;

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnPostFile;

        #endregion
    }
}