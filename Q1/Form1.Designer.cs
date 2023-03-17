namespace Q1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBoxName = new TextBox();
            textBoxID = new TextBox();
            textBoxPhone = new TextBox();
            textBoxIDnumber = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonClose = new Button();
            buttonRefresh = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(textBoxIDnumber);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(200, 95);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 12;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(95, 95);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 11;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(94, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(94, 54);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 9;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(94, 12);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(94, 171);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 23);
            textBoxPhone.TabIndex = 7;
            // 
            // textBoxIDnumber
            // 
            textBoxIDnumber.Location = new Point(94, 217);
            textBoxIDnumber.Name = "textBoxIDnumber";
            textBoxIDnumber.Size = new Size(100, 23);
            textBoxIDnumber.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 225);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 5;
            label6.Text = "IDNumber";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 179);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 130);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 95);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 54);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonEdit);
            groupBox2.Controls.Add(buttonAdd);
            groupBox2.Controls.Add(buttonClose);
            groupBox2.Controls.Add(buttonRefresh);
            groupBox2.Location = new Point(588, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 253);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Button";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(102, 54);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 54);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(102, 22);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(6, 22);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 261);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "View data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(740, 222);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 558);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxID;
        private TextBox textBoxPhone;
        private TextBox textBoxIDnumber;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxName;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonClose;
        private Button buttonRefresh;
    }
}