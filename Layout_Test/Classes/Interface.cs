using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Layout_Test.Classes
{
    //LiteBox does not work yet, check out this link:
    //http://stackoverflow.com/questions/32400320/any-trick-to-use-opacity-on-a-panel-in-visual-studio-window-form
    public class LiteBox
    {
        public Panel background { get; set; }
        public Panel litebox { get; set; }

        public LiteBox GenerateLiteBox(Size frm)
        {
            LiteBox lb = new LiteBox();
            Panel pbg = new Panel();
            Panel pbf = new Panel();
            pbg.Name = "pnlLB_BG";
            pbg.Size = frm;
            pbg.BackColor = Color.FromArgb(75, Color.Black);
            pbf.Name = "pnlLB_LB";
            pbf.Size = new Size(200, 300);
            pbf.BackColor = Color.WhiteSmoke;
            lb.background = pbg;
            lb.litebox = pbf;
            return lb;
        }
    }

    public class Interface
    {
        public string charName { get; set; }
        public Panel charPanel { get; set; }
        public Button charButton { get; set; }
        public Button deleteButton { get; set; }

        public List<Interface> lstCI = new List<Interface>();
        public List<Interface> Get_lstCI() { return lstCI; }

        public Interface AddCharacter(string character, int flw_width, Size pnl_size)
        {
            Interface ci = new Interface();
            ci.charName = character;
            ci.charButton = CreateCharButton(ci.charName, flw_width);
            ci.charPanel = CreateCharPanel(ci.charName, pnl_size);
            ci.deleteButton = CreateCharDeleteButton(ci.charName, ci.charPanel);
            lstCI.Add(ci);
            return ci;
        }

        public void HideAllCharacterPanels(FlowLayoutPanel flw)
        {
            foreach (Panel p in flw.Controls)
            {
                p.Visible = false;
            }
        }

        public bool CheckCharacterExists(string character)
        {
            bool res = false;
            foreach (var r in lstCI)
            {
                if (r.charName == character)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        private Panel CreateCharPanel(string name, Size pnl_size)
        {
            Panel cp = new Panel();
            cp.Name = "pnlChar_" + name;
            cp.BackColor = RandomColor();
            cp.Size = pnl_size;
            cp.Padding = new Padding(0);
            cp.Margin = new Padding(0);

            var foreColor = (PerceivedBrightness(cp.BackColor) > 130 ? Color.Black : Color.White);

            Label l = new Label();
            l.Name = "lblChar_" + name;
            l.Text = name;
            l.ForeColor = foreColor;
            l.Font = new Font("Calibri", 18);
            l.AutoSize = true;
            l.Location = new Point(10, 10);
            cp.Controls.Add(l);

            return cp;
        }

        private Button CreateCharButton(string name, int width)
        {
            Button cb = new Button();
            cb.Name = "buChar_" + name;
            cb.Text = name;
            cb.BackColor = Color.Crimson;
            cb.ForeColor = Color.White;
            cb.Width = width;
            cb.Height = 50;
            return cb;
        }

        private Button CreateCharDeleteButton(string name, Panel panel)
        {
            Button cd = new Button();
            cd.Name = "buChar_" + name + "_Del";
            cd.Text = "Delete Character";
            cd.BackColor = Color.Crimson;
            cd.ForeColor = Color.White;
            cd.AutoSize = true;
            cd.Location = new Point(panel.Width - cd.Width, 10);
            return cd;
        }

        private Color RandomColor()
        {
            Random r = new Random();
            return Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private int PerceivedBrightness(Color c)
        {
            return (int)Math.Sqrt(
            c.R * c.R * .299 +
            c.G * c.G * .587 +
            c.B * c.B * .114);
        }
    }
}