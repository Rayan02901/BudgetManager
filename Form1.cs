using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class Form1 : Form
    {
        // Lists to store income and expense records
        private List<Income> incomes = new List<Income>();
        private List<Expense> expenses = new List<Expense>();

        // Tracks the current budget balance
        private decimal budget = 0m;

        // File path for persistent data storage
        private string dataFilePath = "budget_data.txt";

        public Form1()
        {
            // Standard Windows Forms initialization
            InitializeComponent();

            // Event handlers for button clicks and link interactions
            AddIncome.Click += AddIncome_Click;
            AddExpense.Click += AddExpense_Click;
            HelpLinkLabel.LinkClicked += HelpLinkLabel_LinkClicked;

            // Load existing data from file when application starts
            LoadDataFromFile();
        }

        // Reads saved budget data from a text file
        private void LoadDataFromFile()
        {
            if (File.Exists(dataFilePath))
            {
                // Read all lines from the data file
                string[] lines = File.ReadAllLines(dataFilePath);
                foreach (var line in lines)
                {
                    // Split each line into parts based on comma separator
                    string[] parts = line.Split(',');

                    // Reconstruct income entries
                    if (parts[0] == "Income")
                    {
                        incomes.Add(new Income { Amount = decimal.Parse(parts[1]) });
                    }
                    // Reconstruct expense entries
                    else if (parts[0] == "Expense")
                    {
                        expenses.Add(new Expense
                        {
                            Description = parts[1],
                            Amount = decimal.Parse(parts[2]),
                            IsConfirmed = bool.Parse(parts[3])
                        });
                    }
                }
                // Update budget and UI after loading data
                UpdateBudget();
                UpdateListViews();
            }
        }

        // Writes current budget data to a text file for persistence
        private void SaveDataToFile()
        {
            List<string> lines = new List<string>();

            // Convert income entries to CSV format
            foreach (var income in incomes)
            {
                lines.Add($"Income,{income.Amount}");
            }

            // Convert expense entries to CSV format
            foreach (var expense in expenses)
            {
                lines.Add($"Expense,{expense.Description},{expense.Amount},{expense.IsConfirmed}");
            }

            // Write all lines to the data file
            File.WriteAllLines(dataFilePath, lines.ToArray());
        }

        // Handles adding new income entries
        private void AddIncome_Click(object sender, EventArgs e)
        {
            // Validate income amount input
            if (decimal.TryParse(IncomeAmount.Text, out decimal amount) && amount > 0)
            {
                incomes.Add(new Income { Amount = amount });
                IncomeAmount.Clear();

                // Update budget, UI, and save data
                UpdateBudget();
                UpdateListViews();
                SaveDataToFile();
            }
            else
            {
                // Show error for invalid income input
                MessageBox.Show("Please enter a valid, positive income amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles adding new expense entries
        private void AddExpense_Click(object sender, EventArgs e)
        {
            // Validate expense description
            string description = ExpenseDescription.Text.Trim();
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter an expense description.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate expense amount input
            if (decimal.TryParse(ExpenseAmount.Text, out decimal amount) && amount > 0)
            {
                // Check if expense is confirmed
                bool isConfirmed = ConfirmExpenseCheckBox.Checked;

                expenses.Add(new Expense
                {
                    Description = description,
                    Amount = amount,
                    IsConfirmed = isConfirmed
                });

                // Clear input fields
                ExpenseDescription.Clear();
                ExpenseAmount.Clear();
                ConfirmExpenseCheckBox.Checked = false;

                // Update budget, UI, and save data
                UpdateBudget();
                UpdateListViews();
                SaveDataToFile();
            }
            else
            {
                // Show error for invalid expense input
                MessageBox.Show("Please enter a valid, positive expense amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calculates current budget by summing incomes and subtracting confirmed expenses
        private void UpdateBudget()
        {
            budget = 0m;

            // Add all income amounts
            foreach (var income in incomes)
            {
                budget += income.Amount;
            }

            // Subtract only confirmed expenses
            foreach (var expense in expenses.Where(e => e.IsConfirmed))
            {
                budget -= expense.Amount;
            }

            // Display total budget in currency format
            Total.Text = budget.ToString("C");
        }

        // Updates list views for incomes, unconfirmed and confirmed expenses
        private void UpdateListViews()
        {
            // Populate Income ListView
            IncomesListView.Items.Clear();
            if (incomes.Count > 0)
            {
                IncomesListView.Items.Add(new ListViewItem(new[] { "Incomes", "Amount" }));
                int incomeIndex = 1;
                foreach (var income in incomes)
                {
                    IncomesListView.Items.Add(new ListViewItem(new[] { $"Income {incomeIndex}", income.Amount.ToString("C") }));
                    incomeIndex++;
                }
            }

            // Populate Unconfirmed Expenses ListView
            UnconfirmedExpensesListView.Items.Clear();
            var unconfirmedExpenses = expenses.Where(e => !e.IsConfirmed).ToList();
            if (unconfirmedExpenses.Count > 0)
            {
                UnconfirmedExpensesListView.Items.Add(new ListViewItem(new[] { "Unconfirmed Expenses", "Amount" }));
                foreach (var expense in unconfirmedExpenses)
                {
                    UnconfirmedExpensesListView.Items.Add(new ListViewItem(new[] { expense.Description, expense.Amount.ToString("C") }));
                }
            }

            // Populate Confirmed Expenses ListView
            ConfirmedExpensesListView.Items.Clear();
            var confirmedExpenses = expenses.Where(e => e.IsConfirmed).ToList();
            if (confirmedExpenses.Count > 0)
            {
                ConfirmedExpensesListView.Items.Add(new ListViewItem(new[] { "Confirmed Expenses", "Amount" }));
                foreach (var expense in confirmedExpenses)
                {
                    ConfirmedExpensesListView.Items.Add(new ListViewItem(new[] { expense.Description, expense.Amount.ToString("C") }));
                }
            }
        }

        // Opens help dialog when help link is clicked
        private void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowHelpDialog();
        }

        // Displays help information in a modal dialog
        private void ShowHelpDialog()
        {
            // Comprehensive help text explaining application usage
            string helpText = @"Budget Manager Application Guide

How to Use the Application:

1. Adding Income
- Enter the income amount in the 'Income Amount' field
- Click 'Add Income' button
- Income will be added to the Incomes list

2. Adding Expenses
- Enter expense description in 'Expense Description' field
- Enter expense amount in 'Expense Amount' field
- Use the 'Confirm Expense' checkbox to mark expense status
   - Unchecked: Expense will appear in Unconfirmed Expenses list.
     It means the Expense that You want to Carry out but are not
     sure if it is within the budget. So this you will keep for 
     Reminder and If you have enough Budget At the end of month then
     You can confirm the Expense.
   - Checked: Expense will appear in Confirmed Expenses list.
     These are the expenses that have already been carried out or the 
     compulsory expenses that you cannot Shy away from.

3. Budget Calculation
- Total budget is calculated as: 
  Total = Sum of Incomes - Confirmed Expenses
- The current budget is displayed in the Total field

4. Data Persistence
- All income and expense data is automatically saved
- Data is stored in 'budget_data.txt' file
- Data is loaded automatically when application starts

Tips:
- Always enter positive amounts
- Use the 'Confirm Expense' checkbox to track expense status
- Regularly review your income and expenses";

            // Create a modal help dialog
            using (Form helpForm = new Form())
            {
                helpForm.Text = "Budget Manager Help";
                helpForm.Size = new Size(400, 500);
                helpForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                helpForm.MaximizeBox = false;
                helpForm.StartPosition = FormStartPosition.CenterScreen;

                // Create a read-only multiline TextBox to display help text
                TextBox helpTextBox = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    Dock = DockStyle.Fill,
                    Text = helpText,
                    ScrollBars = ScrollBars.Vertical
                };

                helpForm.Controls.Add(helpTextBox);
                helpForm.ShowDialog();
            }
        }
    }

    // Simple class to represent income entries
    public class Income
    {
        public decimal Amount { get; set; }
    }

    // Class to represent expense entries with additional tracking
    public class Expense
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool IsConfirmed { get; set; }
    }
}