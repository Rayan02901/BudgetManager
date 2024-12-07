using System;

namespace BudgetManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IncomeAmount = new System.Windows.Forms.TextBox();
            this.ExpenseDescription = new System.Windows.Forms.TextBox();
            this.ExpenseAmount = new System.Windows.Forms.TextBox();
            this.AddIncome = new System.Windows.Forms.Button();
            this.AddExpense = new System.Windows.Forms.Button();
            this.IncomesListView = new System.Windows.Forms.ListView();
            this.Total = new System.Windows.Forms.TextBox();
            this.ConfirmExpenseCheckBox = new System.Windows.Forms.CheckBox();
            this.UnconfirmedExpensesListView = new System.Windows.Forms.ListView();
            this.ConfirmedExpensesListView = new System.Windows.Forms.ListView();
            this.HelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expense Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expense Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // IncomeAmount
            // 
            this.IncomeAmount.Location = new System.Drawing.Point(216, 30);
            this.IncomeAmount.Name = "IncomeAmount";
            this.IncomeAmount.Size = new System.Drawing.Size(123, 22);
            this.IncomeAmount.TabIndex = 4;
            // 
            // ExpenseDescription
            // 
            this.ExpenseDescription.Location = new System.Drawing.Point(216, 111);
            this.ExpenseDescription.Name = "ExpenseDescription";
            this.ExpenseDescription.Size = new System.Drawing.Size(486, 22);
            this.ExpenseDescription.TabIndex = 5;
            // 
            // ExpenseAmount
            // 
            this.ExpenseAmount.Location = new System.Drawing.Point(216, 152);
            this.ExpenseAmount.Name = "ExpenseAmount";
            this.ExpenseAmount.Size = new System.Drawing.Size(123, 22);
            this.ExpenseAmount.TabIndex = 6;
            // 
            // AddIncome
            // 
            this.AddIncome.Location = new System.Drawing.Point(216, 71);
            this.AddIncome.Name = "AddIncome";
            this.AddIncome.Size = new System.Drawing.Size(132, 23);
            this.AddIncome.TabIndex = 7;
            this.AddIncome.Text = "Add Income";
            this.AddIncome.UseVisualStyleBackColor = true;
            // 
            // AddExpense
            // 
            this.AddExpense.Location = new System.Drawing.Point(216, 233);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Size = new System.Drawing.Size(132, 23);
            this.AddExpense.TabIndex = 8;
            this.AddExpense.Text = "Add Expense";
            this.AddExpense.UseVisualStyleBackColor = true;
            // 
            // IncomesListView
            // 
            this.IncomesListView.HideSelection = false;
            this.IncomesListView.Location = new System.Drawing.Point(354, 152);
            this.IncomesListView.Name = "IncomesListView";
            this.IncomesListView.Size = new System.Drawing.Size(180, 341);
            this.IncomesListView.TabIndex = 9;
            this.IncomesListView.UseCompatibleStateImageBehavior = false;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(189, 343);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 22);
            this.Total.TabIndex = 10;
            // 
            // ConfirmExpenseCheckBox
            // 
            this.ConfirmExpenseCheckBox.AutoSize = true;
            this.ConfirmExpenseCheckBox.Location = new System.Drawing.Point(37, 198);
            this.ConfirmExpenseCheckBox.Name = "ConfirmExpenseCheckBox";
            this.ConfirmExpenseCheckBox.Size = new System.Drawing.Size(137, 20);
            this.ConfirmExpenseCheckBox.TabIndex = 11;
            this.ConfirmExpenseCheckBox.Text = "Confirm Expense?";
            this.ConfirmExpenseCheckBox.UseVisualStyleBackColor = true;
            // 
            // UnconfirmedExpensesListView
            // 
            this.UnconfirmedExpensesListView.HideSelection = false;
            this.UnconfirmedExpensesListView.Location = new System.Drawing.Point(548, 149);
            this.UnconfirmedExpensesListView.Name = "UnconfirmedExpensesListView";
            this.UnconfirmedExpensesListView.Size = new System.Drawing.Size(154, 342);
            this.UnconfirmedExpensesListView.TabIndex = 12;
            this.UnconfirmedExpensesListView.UseCompatibleStateImageBehavior = false;
            // 
            // ConfirmedExpensesListView
            // 
            this.ConfirmedExpensesListView.HideSelection = false;
            this.ConfirmedExpensesListView.Location = new System.Drawing.Point(724, 149);
            this.ConfirmedExpensesListView.Name = "ConfirmedExpensesListView";
            this.ConfirmedExpensesListView.Size = new System.Drawing.Size(163, 341);
            this.ConfirmedExpensesListView.TabIndex = 13;
            this.ConfirmedExpensesListView.UseCompatibleStateImageBehavior = false;
            // 
            // HelpLinkLabel
            // 
            this.HelpLinkLabel.AutoSize = true;
            this.HelpLinkLabel.Location = new System.Drawing.Point(615, 30);
            this.HelpLinkLabel.Name = "HelpLinkLabel";
            this.HelpLinkLabel.Size = new System.Drawing.Size(36, 16);
            this.HelpLinkLabel.TabIndex = 14;
            this.HelpLinkLabel.TabStop = true;
            this.HelpLinkLabel.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 552);
            this.Controls.Add(this.HelpLinkLabel);
            this.Controls.Add(this.ConfirmedExpensesListView);
            this.Controls.Add(this.UnconfirmedExpensesListView);
            this.Controls.Add(this.ConfirmExpenseCheckBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.IncomesListView);
            this.Controls.Add(this.AddExpense);
            this.Controls.Add(this.AddIncome);
            this.Controls.Add(this.ExpenseAmount);
            this.Controls.Add(this.ExpenseDescription);
            this.Controls.Add(this.IncomeAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Budget name:";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IncomeAmount;
        private System.Windows.Forms.TextBox ExpenseDescription;
        private System.Windows.Forms.TextBox ExpenseAmount;
        private System.Windows.Forms.Button AddIncome;
        private System.Windows.Forms.Button AddExpense;
        private System.Windows.Forms.ListView IncomesListView;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.CheckBox ConfirmExpenseCheckBox;
        private System.Windows.Forms.ListView UnconfirmedExpensesListView;
        private System.Windows.Forms.ListView ConfirmedExpensesListView;
        private System.Windows.Forms.LinkLabel HelpLinkLabel;
    }
}

