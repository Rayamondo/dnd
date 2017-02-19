using Layout_Test.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Layout_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmSize = Form1.ActiveForm.Size;
            flwCharButtons.Margin = new Padding(0);
            flwCharScreen.Margin = new Padding(0);
            flwCharButtons.Location = new Point(0, 0);
            flwCharButtons.Size = new Size((frmSize.Width / 100) * 20, frmSize.Height);
            flwCharScreen.Location = new Point(0 + flwCharButtons.Width, 0);
            flwCharScreen.Size = new Size(frmSize.Width - flwCharButtons.Size.Width, frmSize.Height);

            foreach (Control c in flwCharButtons.Controls)
                c.Width = flwCharButtons.Width - 7;
        }

        public Interface ci = new Interface();
        public LiteBox lb = new LiteBox();
        public Size frmSize = new Size();

        private void buChar_add_Click(object sender, EventArgs e)
        {
            AddCharacter();
        }

        private void txtAddChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AddCharacter();
                //Should remove "ding" noise
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AddCharacter()
        {
            if (txtAddChar.Text != "" && ci.CheckCharacterExists(txtAddChar.Text) == false)
            {
                Interface res = ci.AddCharacter(txtAddChar.Text, flwCharButtons.Width - 7, flwCharScreen.Size);
                flwCharButtons.Controls.Add(res.charButton);
                res.charButton.Click += new EventHandler(CharButton_Click);
                flwCharScreen.Controls.Add(res.charPanel);
                res.charPanel.Controls.Add(res.deleteButton);
                res.deleteButton.Click += new EventHandler(CharDeleteButton_Click);
                txtAddChar.Text = "";

                Character c = new Character();
                c.charName = ci.charName;
                //c.charClass.attributes.
                
            }
            else if (ci.CheckCharacterExists(txtAddChar.Text) == true)
            {
                MessageBox.Show(txtAddChar.Text + " already exists as a Character!");
                txtAddChar.Text = "";
            }
        }

        private void CharButton_Click(object sender, EventArgs e)
        {
            Button bu = (Button)sender;
            int i = 0;
            foreach (var r in ci.Get_lstCI())
            {
                if (r.charButton.Name == bu.Name)
                {
                    try
                    {
                        ci.HideAllCharacterPanels(flwCharScreen);
                        Control c = r.charPanel;
                        c.Show();
                        c.BringToFront();
                        c.Width = flwCharScreen.Width;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                i++;
            }
        }

        private void CharDeleteButton_Click(object sender, EventArgs e)
        {
            Button bu = (Button)sender;
            var res = new List<Interface>();
            for (int i = 0; i < ci.lstCI.Count; i++)
            {
                var r = ci.lstCI[i] as Interface;
                if (r.deleteButton.Name == bu.Name)
                    res.Add(r);
            }
            RemoveChar(res);
        }

        private void RemoveChar(List<Interface> DelList)
        {
            for (int i = 0; i < DelList.Count; i++)
            {
                DialogResult remove = MessageBox.Show("Are you sure you want to delete " +
                    DelList[i].charName + "?", "Delete Character", MessageBoxButtons.YesNo);
                if (remove == DialogResult.Yes)
                {
                    Control cd = this.Controls.Find(DelList[i].deleteButton.Name, true).FirstOrDefault();
                    Control pn = this.Controls.Find(DelList[i].charPanel.Name, true).FirstOrDefault();
                    Control bu = this.Controls.Find(DelList[i].charButton.Name, true).FirstOrDefault();
                    pn.Controls.Remove(cd);
                    flwCharScreen.Controls.Remove(pn);
                    flwCharButtons.Controls.Remove(bu);
                    ci.lstCI.Remove(DelList[i]);
                }
            }
        }

        private void buChar_showAll_Click(object sender, EventArgs e)
        {
            if (flwCharScreen.Controls.Count != 0)
            {
                int w = flwCharScreen.Width / flwCharScreen.Controls.Count;
                int i = 0;
                foreach (Panel p in flwCharScreen.Controls)
                {
                    p.Size = new Size(w, flwCharScreen.Height);
                    p.Visible = true;
                    i = p.Location.X + p.Width;
                }
            }
        }
    }
}