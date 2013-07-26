namespace ATMSimulator
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
            this.components = new System.ComponentModel.Container();
            this.displayScreen = new System.Windows.Forms.TextBox();
            this.customerInput = new System.Windows.Forms.TextBox();
            this.processBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.depositSlotLabel = new System.Windows.Forms.Label();
            this.cashDispenserLabel = new System.Windows.Forms.Label();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAccounts = new ATMSimulator.userAccounts();
            this.accountsTableAdapter = new ATMSimulator.userAccountsTableAdapters.AccountsTableAdapter();
            this.tableAdapterManager = new ATMSimulator.userAccountsTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // displayScreen
            // 
            this.displayScreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayScreen.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayScreen.Location = new System.Drawing.Point(294, 12);
            this.displayScreen.Multiline = true;
            this.displayScreen.Name = "displayScreen";
            this.displayScreen.ReadOnly = true;
            this.displayScreen.Size = new System.Drawing.Size(445, 331);
            this.displayScreen.TabIndex = 0;
            // 
            // customerInput
            // 
            this.customerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInput.Location = new System.Drawing.Point(438, 359);
            this.customerInput.Name = "customerInput";
            this.customerInput.ReadOnly = true;
            this.customerInput.Size = new System.Drawing.Size(165, 29);
            this.customerInput.TabIndex = 1;
            // 
            // processBtn
            // 
            this.processBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processBtn.Location = new System.Drawing.Point(148, 294);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(131, 49);
            this.processBtn.TabIndex = 2;
            this.processBtn.Text = "Enter";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(100, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(191, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 65);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(191, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 65);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(100, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 65);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 65);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(191, 194);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 65);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(100, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 65);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 65);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(13, 294);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(129, 49);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // depositSlotLabel
            // 
            this.depositSlotLabel.AutoSize = true;
            this.depositSlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositSlotLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.depositSlotLabel.Location = new System.Drawing.Point(78, 428);
            this.depositSlotLabel.Name = "depositSlotLabel";
            this.depositSlotLabel.Size = new System.Drawing.Size(219, 42);
            this.depositSlotLabel.TabIndex = 13;
            this.depositSlotLabel.Text = "Deposit Slot";
            // 
            // cashDispenserLabel
            // 
            this.cashDispenserLabel.AutoSize = true;
            this.cashDispenserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashDispenserLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cashDispenserLabel.Location = new System.Drawing.Point(416, 428);
            this.cashDispenserLabel.Name = "cashDispenserLabel";
            this.cashDispenserLabel.Size = new System.Drawing.Size(285, 42);
            this.cashDispenserLabel.TabIndex = 14;
            this.cashDispenserLabel.Text = "Cash Dispenser";
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.userAccounts;
            // 
            // userAccounts
            // 
            this.userAccounts.DataSetName = "userAccounts";
            this.userAccounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableAdapter = this.accountsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ATMSimulator.userAccountsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 521);
            this.Controls.Add(this.cashDispenserLabel);
            this.Controls.Add(this.depositSlotLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.customerInput);
            this.Controls.Add(this.displayScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayScreen;
        private System.Windows.Forms.TextBox customerInput;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label depositSlotLabel;
        private System.Windows.Forms.Label cashDispenserLabel;
        private userAccounts userAccounts;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private userAccountsTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private userAccountsTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

