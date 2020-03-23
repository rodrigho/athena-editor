using AthenaEditor.controllers;
using AthenaEditor.entities;
using AthenaEditor.util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthenaEditor
{
    public partial class ConnectionManager : Form
    {
        public MainController MainController { get; set; }
        public ConnectionManager()
        {
            InitializeComponent();

            MainController = MainController.GetInstance();
            MainController.ConnectionManager = this;

            formatListView(listViewConnections);
            loadConnections();

            setLoadComponents();
        }

        private void setLoadComponents()
        {
            buttonDelete.Enabled = false;
        }

        private void formatListView(ListView listView)
        {
            ImageList imagelist = new ImageList();
            imagelist.Images.Add(Image.FromFile(Path.Combine(MainController.RelativePath, "icons\\icons8-quick-mode-on-16.png")));
            listView.View = View.Details;
            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.FullRowSelect = true;
            listView.SmallImageList = imagelist;
            listView.Columns.Add("Column", 150, HorizontalAlignment.Left);
        }

        private void loadConnections()
        {
            try
            {
                string jsonFile = Path.Combine(MainController.RelativePath, "connections.json");
                string jsonText = File.ReadAllText(jsonFile);

                MainController.Connections = JsonConvert.DeserializeObject<List<Connection>>(jsonText);

                foreach (Connection connection in MainController.Connections)
                {
                    listViewConnections.Items.Add(new ListViewItem { ImageIndex = 0, Text = " - " + connection.Name });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TextConstants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text.Trim()))
            {
                Connection connection = new Connection(textBoxName.Text, textBoxDatabase.Text, textBoxS3bucket.Text, textBoxAccessKeyId.Text,
                    textBoxSecretKey.Text, comboBoxRegion.SelectedItem.ToString(), richTextBoxComments.Text);
                MainController.Connections.Add(connection);
                listViewConnections.Items.Add(new ListViewItem { ImageIndex = 0, Text = " - " + connection.Name });
            }

            string json = JsonConvert.SerializeObject(MainController.Connections);
            string jsonFile = Path.Combine(MainController.RelativePath, "connections.json");

            //write string to file
            File.WriteAllText(jsonFile, json);            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }

        private void listViewConnections_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            MainController.StartMainForm();
        }

        //attributes
        public ListView ListViewConnections { get { return listViewConnections; } }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewConnections.SelectedItems.Count > 0)
            {
                int index = listViewConnections.SelectedItems[0].Index;
                MainController.Connections.RemoveAt(index);
                listViewConnections.Items.RemoveAt(index);
                buttonDelete.Enabled = false;
                textBoxName.Text = "";
                textBoxDatabase.Text = "";
                textBoxS3bucket.Text = "";
                textBoxAccessKeyId.Text = "";
                textBoxSecretKey.Text = "";
                comboBoxRegion.SelectedItem = null;
                richTextBoxComments.Text = "";
            }
            else
            {
                MessageBox.Show(TextConstants.ErrorDeleteConnections, TextConstants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = true;
            if (listViewConnections.SelectedItems.Count > 0)
            {
                int index = listViewConnections.SelectedItems[0].Index;
                MainController.CurrentConnection = MainController.Connections[index];
                textBoxName.Text = MainController.CurrentConnection.Name;
                textBoxDatabase.Text = MainController.CurrentConnection.AthenaDatabase;
                textBoxS3bucket.Text = MainController.CurrentConnection.AthenaOutputBucket;
                textBoxAccessKeyId.Text = MainController.CurrentConnection.AccessKeyId;
                textBoxSecretKey.Text = MainController.CurrentConnection.SecretKey;
                comboBoxRegion.SelectedItem = MainController.CurrentConnection.Region;
                richTextBoxComments.Text = MainController.CurrentConnection.Comment;
            }
        }
    }
}
