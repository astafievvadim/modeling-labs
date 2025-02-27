namespace modeling_lab
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.inProgressTextBox = new System.Windows.Forms.TextBox();
            this.setInfixButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.alphabetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.oneStepButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.decisionDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stackFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.automaticRadioButton = new System.Windows.Forms.RadioButton();
            this.stepRadioButton = new System.Windows.Forms.RadioButton();
            this.pointerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decisionDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inProgressTextBox);
            this.panel1.Controls.Add(this.setInfixButton);
            this.panel1.Controls.Add(this.inputTextBox);
            this.panel1.Controls.Add(this.outputTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 99);
            this.panel1.TabIndex = 0;
            // 
            // inProgressTextBox
            // 
            this.inProgressTextBox.Location = new System.Drawing.Point(15, 21);
            this.inProgressTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.inProgressTextBox.Name = "inProgressTextBox";
            this.inProgressTextBox.ReadOnly = true;
            this.inProgressTextBox.Size = new System.Drawing.Size(250, 20);
            this.inProgressTextBox.TabIndex = 4;
            // 
            // setInfixButton
            // 
            this.setInfixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setInfixButton.Location = new System.Drawing.Point(518, 13);
            this.setInfixButton.Name = "setInfixButton";
            this.setInfixButton.Size = new System.Drawing.Size(250, 23);
            this.setInfixButton.TabIndex = 3;
            this.setInfixButton.Text = "Задать";
            this.setInfixButton.UseVisualStyleBackColor = true;
            this.setInfixButton.Click += new System.EventHandler(this.setInfixButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(518, 66);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(250, 20);
            this.inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(14, 67);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(15);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(250, 20);
            this.outputTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 506);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Location = new System.Drawing.Point(0, 98);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(785, 330);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.alphabetButton);
            this.panel8.Controls.Add(this.stopButton);
            this.panel8.Controls.Add(this.startButton);
            this.panel8.Controls.Add(this.oneStepButton);
            this.panel8.Location = new System.Drawing.Point(0, 267);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(783, 58);
            this.panel8.TabIndex = 2;
            // 
            // alphabetButton
            // 
            this.alphabetButton.Location = new System.Drawing.Point(507, 17);
            this.alphabetButton.Name = "alphabetButton";
            this.alphabetButton.Size = new System.Drawing.Size(75, 23);
            this.alphabetButton.TabIndex = 3;
            this.alphabetButton.Text = "Словарь";
            this.alphabetButton.UseVisualStyleBackColor = true;
            this.alphabetButton.Click += new System.EventHandler(this.alphabetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stopButton.Location = new System.Drawing.Point(283, 17);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(79, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.startButton.Location = new System.Drawing.Point(198, 17);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(79, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // oneStepButton
            // 
            this.oneStepButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oneStepButton.Location = new System.Drawing.Point(368, 17);
            this.oneStepButton.Name = "oneStepButton";
            this.oneStepButton.Size = new System.Drawing.Size(79, 23);
            this.oneStepButton.TabIndex = 0;
            this.oneStepButton.Text = "Один такт";
            this.oneStepButton.UseVisualStyleBackColor = true;
            this.oneStepButton.Click += new System.EventHandler(this.oneStepButton_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(598, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 261);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.decisionDataGridView);
            this.panel4.Location = new System.Drawing.Point(191, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 261);
            this.panel4.TabIndex = 2;
            // 
            // decisionDataGridView
            // 
            this.decisionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decisionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.decisionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.decisionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.decisionDataGridView.Location = new System.Drawing.Point(7, 26);
            this.decisionDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.decisionDataGridView.Name = "decisionDataGridView";
            this.decisionDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.decisionDataGridView.Size = new System.Drawing.Size(384, 225);
            this.decisionDataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.pointerFlowLayoutPanel);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.stackFlowLayoutPanel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 261);
            this.panel3.TabIndex = 1;
            // 
            // stackFlowLayoutPanel
            // 
            this.stackFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stackFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.stackFlowLayoutPanel.Location = new System.Drawing.Point(92, 29);
            this.stackFlowLayoutPanel.Name = "stackFlowLayoutPanel";
            this.stackFlowLayoutPanel.Size = new System.Drawing.Size(84, 229);
            this.stackFlowLayoutPanel.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.automaticRadioButton);
            this.panel6.Controls.Add(this.stepRadioButton);
            this.panel6.Location = new System.Drawing.Point(0, 434);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(785, 72);
            this.panel6.TabIndex = 4;
            // 
            // automaticRadioButton
            // 
            this.automaticRadioButton.AutoSize = true;
            this.automaticRadioButton.Location = new System.Drawing.Point(100, 45);
            this.automaticRadioButton.Name = "automaticRadioButton";
            this.automaticRadioButton.Size = new System.Drawing.Size(103, 17);
            this.automaticRadioButton.TabIndex = 1;
            this.automaticRadioButton.TabStop = true;
            this.automaticRadioButton.Text = "Автоматически";
            this.automaticRadioButton.UseVisualStyleBackColor = true;
            this.automaticRadioButton.CheckedChanged += new System.EventHandler(this.automaticRadioButton_CheckedChanged);
            // 
            // stepRadioButton
            // 
            this.stepRadioButton.AutoSize = true;
            this.stepRadioButton.Location = new System.Drawing.Point(100, 11);
            this.stepRadioButton.Name = "stepRadioButton";
            this.stepRadioButton.Size = new System.Drawing.Size(76, 17);
            this.stepRadioButton.TabIndex = 0;
            this.stepRadioButton.TabStop = true;
            this.stepRadioButton.Text = "Пошагово";
            this.stepRadioButton.UseVisualStyleBackColor = true;
            this.stepRadioButton.CheckedChanged += new System.EventHandler(this.stepRadioButton_CheckedChanged);
            // 
            // pointerFlowLayoutPanel
            // 
            this.pointerFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pointerFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.pointerFlowLayoutPanel.Location = new System.Drawing.Point(8, 29);
            this.pointerFlowLayoutPanel.Name = "pointerFlowLayoutPanel";
            this.pointerFlowLayoutPanel.Size = new System.Drawing.Size(82, 229);
            this.pointerFlowLayoutPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Режим работы";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.MaximumSize = new System.Drawing.Size(185, 271);
            this.label2.MinimumSize = new System.Drawing.Size(150, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 143);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.MaximumSize = new System.Drawing.Size(185, 271);
            this.label3.MinimumSize = new System.Drawing.Size(150, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 78);
            this.label3.TabIndex = 1;
            this.label3.Text = "$ – символ пустой строки или стека\nF – функция\nP – переменная\n^ – бинарная операц" +
    "ия возведения в степень";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Преобразование выражения к постфиксной форме";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Входная строка (инфиксная)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Выходная строка (постфиксная)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Таблица принятия решений";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Стек";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(816, 560);
            this.Name = "MainForm";
            this.Text = "3-ИАИТ-119 Астафьев Моделирование лаб1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decisionDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button setInfixButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inProgressTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView decisionDataGridView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button oneStepButton;
        private System.Windows.Forms.RadioButton automaticRadioButton;
        private System.Windows.Forms.RadioButton stepRadioButton;
        private System.Windows.Forms.Button alphabetButton;
        private System.Windows.Forms.FlowLayoutPanel stackFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel pointerFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

