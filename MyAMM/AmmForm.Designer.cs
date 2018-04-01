namespace MyAMM
{
    partial class AmmForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgC = new System.Windows.Forms.DataGridView();
            this.dgB = new System.Windows.Forms.DataGridView();
            this.dgA = new System.Windows.Forms.DataGridView();
            this.btnMultBool = new System.Windows.Forms.Button();
            this.btnMultInt = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.btnClearInt = new System.Windows.Forms.Button();
            this.btnAddBool = new System.Windows.Forms.Button();
            this.btnInitBool = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btTransitive = new System.Windows.Forms.Button();
            this.dgD = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btInitTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgC
            // 
            this.dgC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgC.ColumnHeadersVisible = false;
            this.dgC.Location = new System.Drawing.Point(565, 4);
            this.dgC.Name = "dgC";
            this.dgC.RowHeadersVisible = false;
            this.dgC.Size = new System.Drawing.Size(235, 199);
            this.dgC.TabIndex = 5;
            // 
            // dgB
            // 
            this.dgB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgB.ColumnHeadersVisible = false;
            this.dgB.Location = new System.Drawing.Point(281, 4);
            this.dgB.Name = "dgB";
            this.dgB.RowHeadersVisible = false;
            this.dgB.Size = new System.Drawing.Size(247, 199);
            this.dgB.TabIndex = 4;
            // 
            // dgA
            // 
            this.dgA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgA.ColumnHeadersVisible = false;
            this.dgA.Location = new System.Drawing.Point(25, 4);
            this.dgA.Name = "dgA";
            this.dgA.RowHeadersVisible = false;
            this.dgA.Size = new System.Drawing.Size(233, 199);
            this.dgA.TabIndex = 3;
            // 
            // btnMultBool
            // 
            this.btnMultBool.Location = new System.Drawing.Point(182, 287);
            this.btnMultBool.Name = "btnMultBool";
            this.btnMultBool.Size = new System.Drawing.Size(86, 24);
            this.btnMultBool.TabIndex = 21;
            this.btnMultBool.Text = "MultBool";
            this.btnMultBool.UseVisualStyleBackColor = true;
            this.btnMultBool.Click += new System.EventHandler(this.btnMultBool_Click);
            // 
            // btnMultInt
            // 
            this.btnMultInt.Location = new System.Drawing.Point(182, 249);
            this.btnMultInt.Name = "btnMultInt";
            this.btnMultInt.Size = new System.Drawing.Size(90, 21);
            this.btnMultInt.TabIndex = 20;
            this.btnMultInt.Text = "MultInt";
            this.btnMultInt.UseVisualStyleBackColor = true;
            this.btnMultInt.Click += new System.EventHandler(this.btnMultInt_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(36, 225);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 19;
            this.lblN.Text = "N";
            // 
            // btnClearInt
            // 
            this.btnClearInt.Location = new System.Drawing.Point(117, 222);
            this.btnClearInt.Name = "btnClearInt";
            this.btnClearInt.Size = new System.Drawing.Size(75, 23);
            this.btnClearInt.TabIndex = 18;
            this.btnClearInt.Text = "Clear";
            this.btnClearInt.UseVisualStyleBackColor = true;
            this.btnClearInt.Click += new System.EventHandler(this.btnClearInt_Click);
            // 
            // btnAddBool
            // 
            this.btnAddBool.Location = new System.Drawing.Point(101, 287);
            this.btnAddBool.Name = "btnAddBool";
            this.btnAddBool.Size = new System.Drawing.Size(75, 23);
            this.btnAddBool.TabIndex = 17;
            this.btnAddBool.Text = "AddBool";
            this.btnAddBool.UseVisualStyleBackColor = true;
            this.btnAddBool.Click += new System.EventHandler(this.btnAddBool_Click);
            // 
            // btnInitBool
            // 
            this.btnInitBool.Location = new System.Drawing.Point(12, 287);
            this.btnInitBool.Name = "btnInitBool";
            this.btnInitBool.Size = new System.Drawing.Size(83, 23);
            this.btnInitBool.TabIndex = 16;
            this.btnInitBool.Text = "InitBool";
            this.btnInitBool.UseVisualStyleBackColor = true;
            this.btnInitBool.Click += new System.EventHandler(this.btnInitBool_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(101, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "AddInt";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(57, 222);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(43, 20);
            this.tbN.TabIndex = 14;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(12, 248);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(83, 24);
            this.btnInit.TabIndex = 13;
            this.btnInit.Text = "InitInt";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btTransitive
            // 
            this.btTransitive.Location = new System.Drawing.Point(416, 247);
            this.btTransitive.Name = "btTransitive";
            this.btTransitive.Size = new System.Drawing.Size(93, 63);
            this.btTransitive.TabIndex = 22;
            this.btTransitive.Text = "Transitive closure";
            this.btTransitive.UseVisualStyleBackColor = true;
            this.btTransitive.Click += new System.EventHandler(this.btTransitive_Click);
            // 
            // dgD
            // 
            this.dgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgD.ColumnHeadersVisible = false;
            this.dgD.Location = new System.Drawing.Point(565, 225);
            this.dgD.Name = "dgD";
            this.dgD.RowHeadersVisible = false;
            this.dgD.Size = new System.Drawing.Size(235, 199);
            this.dgD.TabIndex = 24;
            this.dgD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(6, 4);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(13, 13);
            this.lb1.TabIndex = 26;
            this.lb1.Text = "1";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(264, 4);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(13, 13);
            this.lb2.TabIndex = 27;
            this.lb2.Text = "2";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(546, 4);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(13, 13);
            this.lb3.TabIndex = 28;
            this.lb3.Text = "3";
            // 
            // btInitTrans
            // 
            this.btInitTrans.Location = new System.Drawing.Point(305, 258);
            this.btInitTrans.Name = "btInitTrans";
            this.btInitTrans.Size = new System.Drawing.Size(84, 41);
            this.btInitTrans.TabIndex = 30;
            this.btInitTrans.Text = "Init Transitive";
            this.btInitTrans.UseVisualStyleBackColor = true;
            this.btInitTrans.Click += new System.EventHandler(this.btInitTrans_Click);
            // 
            // AmmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 434);
            this.Controls.Add(this.btInitTrans);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dgD);
            this.Controls.Add(this.btTransitive);
            this.Controls.Add(this.btnMultBool);
            this.Controls.Add(this.btnMultInt);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnClearInt);
            this.Controls.Add(this.btnAddBool);
            this.Controls.Add(this.btnInitBool);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.dgC);
            this.Controls.Add(this.dgB);
            this.Controls.Add(this.dgA);
            this.Name = "AmmForm";
            this.Text = "AMM";
            ((System.ComponentModel.ISupportInitialize)(this.dgC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMultBool;
        private System.Windows.Forms.Button btnMultInt;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button btnClearInt;
        private System.Windows.Forms.Button btnAddBool;
        private System.Windows.Forms.Button btnInitBool;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Button btnInit;
        public System.Windows.Forms.DataGridView dgC;
        public System.Windows.Forms.DataGridView dgB;
        public System.Windows.Forms.DataGridView dgA;
        private System.Windows.Forms.Button btTransitive;
        public System.Windows.Forms.DataGridView dgD;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btInitTrans;
    }
}

