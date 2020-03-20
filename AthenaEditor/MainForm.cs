using AthenaEditor.controllers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AthenaEditor
{
    public partial class MainForm : Form
    {

        MainController mainController;
        private string[] sqlwords = { "select ", " select "," from "," where "," group "," order "," limit "," by "," and ",
            " having ", " desc ", " asc "};
        public MainForm()
        {
            InitializeComponent();

            formatButtonIcon(buttonExecuteCurrent);
            formatButtonIcon(buttonExecuteSelected);
            formatButtonIcon(buttonSave);
            formatButtonIcon(buttonLoad);
            formatButtonIcon(buttonQueryId);

            mainController = new MainController();
        }

        private void formatButtonIcon(Button button)
        {
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void formatTextSQL(RichTextBox richTextBox)
        {
            int actualPos = richTextBox.SelectionStart;
            foreach (string val in sqlwords)
            {
                int pos = richTextBox.Text.IndexOf(val);
                if(pos >= 0)
                {
                    richTextBox.Select(pos, val.Length);
                    richTextBox.SelectionColor = Color.Blue;
                }
            }           
            richTextBox.Select(actualPos, 0);
            richTextBox.SelectionColor = Color.Black;
        }        

        public static void ThreadSafe(Action action)
        {
            Dispatcher.CurrentDispatcher.Invoke(DispatcherPriority.Normal,
                new MethodInvoker(action));
        }

        private void buttonExecuteCurrent_Click(object sender, EventArgs e)
        {
            ThreadSafe(() =>
            {
                mainController.ExecuteCurrent(richTextBoxQuery.Text, false, "", dataGridViewResult, tabControlResult);
                richTextBoxLog.Text = "\n\n" + richTextBoxLog.Text + richTextBoxQuery.Text + "\n";
                richTextBoxLog.Text = richTextBoxLog.Text + "Query completed...";
            });
            richTextBoxQueryIds.Clear();
            foreach (String query in mainController.QueryExecutionIds)
            {
                richTextBoxQueryIds.AppendText(query+"\n");
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ThreadSafe(() =>
            {
                Thread.Sleep(2000);
                mainController.Salute();
                Thread.Sleep(2000);
            });
        }

        private void richTextBoxQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                buttonExecuteCurrent.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void buttonQueryId_Click(object sender, EventArgs e)
        {
            ThreadSafe(() =>
            {
                mainController.ExecuteCurrent(richTextBoxQuery.Text, true, textBoxQueryId.Text, dataGridViewResult, tabControlResult);
                richTextBoxLog.Text = "\n\n" + richTextBoxLog.Text + richTextBoxQuery.Text + "\n";
                richTextBoxLog.Text = richTextBoxLog.Text + "QueryExecutionId completed...";
            });
        }

        private void textBoxQueryId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                buttonQueryId.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBoxQuery_TextChanged(object sender, EventArgs e)
        {
            formatTextSQL(richTextBoxQuery);
        }
    }
}
