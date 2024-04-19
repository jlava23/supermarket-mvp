namespace Supermarker_mvp.views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            TabPagePayModeList = new TabPage();
            TxtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            Pay = new Label();
            button5 = new Button();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            tabPagePayModeDetail = new TabPage();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            TxtPayModeObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            TabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 76);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 35);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 76);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(515, 321);
            tabControl1.TabIndex = 1;
            // 
            // TabPagePayModeList
            // 
            TabPagePayModeList.Controls.Add(TxtSearch);
            TabPagePayModeList.Controls.Add(dataGridView1);
            TabPagePayModeList.Controls.Add(Pay);
            TabPagePayModeList.Controls.Add(button5);
            TabPagePayModeList.Controls.Add(BtnClose);
            TabPagePayModeList.Controls.Add(BtnEdit);
            TabPagePayModeList.Controls.Add(BtnNew);
            TabPagePayModeList.Controls.Add(BtnSearch);
            TabPagePayModeList.Location = new Point(4, 24);
            TabPagePayModeList.Name = "TabPagePayModeList";
            TabPagePayModeList.Padding = new Padding(3);
            TabPagePayModeList.Size = new Size(507, 293);
            TabPagePayModeList.TabIndex = 0;
            TabPagePayModeList.Text = "Pay Mode List";
            TabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(17, 35);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.RightToLeft = RightToLeft.No;
            TxtSearch.Size = new Size(283, 23);
            TxtSearch.TabIndex = 16;
            TxtSearch.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(351, 209);
            dataGridView1.TabIndex = 15;
            // 
            // Pay
            // 
            Pay.AutoSize = true;
            Pay.Location = new Point(17, 10);
            Pay.Name = "Pay";
            Pay.Size = new Size(98, 15);
            Pay.TabIndex = 14;
            Pay.Text = "Search Pay Mode";
            Pay.Click += label2_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Location = new Point(374, 236);
            button5.Name = "button5";
            button5.Size = new Size(115, 49);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.BackgroundImage = (Image)resources.GetObject("BtnClose.BackgroundImage");
            BtnClose.BackgroundImageLayout = ImageLayout.Center;
            BtnClose.Location = new Point(374, 184);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(115, 46);
            BtnClose.TabIndex = 12;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.BackgroundImage = (Image)resources.GetObject("BtnEdit.BackgroundImage");
            BtnEdit.BackgroundImageLayout = ImageLayout.Center;
            BtnEdit.Location = new Point(374, 128);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(115, 50);
            BtnEdit.TabIndex = 11;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.BackgroundImage = (Image)resources.GetObject("BtnNew.BackgroundImage");
            BtnNew.BackgroundImageLayout = ImageLayout.Center;
            BtnNew.Location = new Point(374, 76);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(115, 43);
            BtnNew.TabIndex = 10;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.AccessibleName = " ";
            BtnSearch.BackgroundImage = (Image)resources.GetObject("BtnSearch.BackgroundImage");
            BtnSearch.BackgroundImageLayout = ImageLayout.Center;
            BtnSearch.Location = new Point(306, 26);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(62, 38);
            BtnSearch.TabIndex = 9;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Controls.Add(label2);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(507, 293);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 17);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Pay Mode Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 62);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 1;
            label3.Text = "Pay Mode Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 113);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Observation";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(36, 36);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(142, 23);
            TxtPayModeId.TabIndex = 3;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(36, 87);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(250, 23);
            TxtPayModeName.TabIndex = 4;
            TxtPayModeName.Text = "Pay Mode Name";
            TxtPayModeName.TextChanged += textBox2_TextChanged;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(36, 140);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(250, 59);
            TxtPayModeObservation.TabIndex = 5;
            TxtPayModeObservation.Text = "Pay mode observation";
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = (Image)resources.GetObject("BtnSave.BackgroundImage");
            BtnSave.BackgroundImageLayout = ImageLayout.Center;
            BtnSave.Location = new Point(37, 231);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(91, 52);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = (Image)resources.GetObject("BtnCancel.BackgroundImage");
            BtnCancel.BackgroundImageLayout = ImageLayout.Center;
            BtnCancel.Location = new Point(156, 229);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(93, 54);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 397);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "PayModeView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            TabPagePayModeList.ResumeLayout(false);
            TabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage TabPagePayModeList;
        private TextBox TxtSearch;
        private DataGridView dataGridView1;
        private Label Pay;
        private Button button5;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TabPage tabPagePayModeDetail;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Button BtnCancel;
        private Button BtnSave;
    }
}