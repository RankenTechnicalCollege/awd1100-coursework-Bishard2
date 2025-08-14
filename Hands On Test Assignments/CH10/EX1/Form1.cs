using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        private readonly List<Occasion> _data = new List<Occasion>();
        private readonly Order _order = new Order();
        public Form1()
        {
            InitializeComponent();
            WireFocusColor(cboOccasion);
            WireFocusColor(cboStyle);
            WireFocusColor(txtMessage);

            cboOccasion.SelectedIndexChanged += cboOccasion_SelectedIndexChanged;
            cboStyle.SelectedIndexChanged += cboStyle_SelectedIndexChanged;

            chkEnvelope.CheckedChanged += AnyOptionChanged;
            chkStamp.CheckedChanged += AnyOptionChanged;
            chkCustom.CheckedChanged += chkCustom_CheckedChanged;
            txtMessage.TextChanged += txtMessage_TextChanged;

            Load += Form1_Load;
        }
        private void WireFocusColor(Control c)
        {
            c.Enter += delegate { c.BackColor = Color.LightGreen; };
            c.Leave += delegate
            {
                c.BackColor = (c is TextBox) ? SystemColors.Window : SystemColors.Control;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var thankYou = new Occasion("Thank You", new[]
            {
                new Style("Tree", 1.25m, null),
                new Style("Floral", 1.50m, null),
                new Style("Minimal", 1.00m, null)
            });

            var birthday = new Occasion("Birthday", new[]
            {
                new Style("Balloons", 1.25m, null),
                new Style("Confetti", 1.35m, null)
            });

            var holiday = new Occasion("Holiday", new[]
            {
                new Style("Snow", 1.40m, null),
                new Style("Ornaments", 1.55m, null)
            });

            _data.Add(thankYou);
            _data.Add(birthday);
            _data.Add(holiday);

            cboOccasion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStyle.DropDownStyle = ComboBoxStyle.DropDownList;

            cboOccasion.DataSource = _data;

            chkCustom.Checked = false;
            txtMessage.Enabled = false;

            UpdateUI();
        }

        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var occ = cboOccasion.SelectedItem as Occasion;
            _order.Occasion = occ;

            cboStyle.DataSource = null;
            if (occ != null) cboStyle.DataSource = occ.Styles;

            if (occ != null && occ.Styles.Count > 0)
            {
                cboStyle.SelectedIndex = 0;
            }
            UpdateUI();
        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.Style = cboStyle.SelectedItem as Style;
            if (_order.Style != null)
                picPreview.Image = _order.Style.Art;
            UpdateUI();
        }

        private void AnyOptionChanged(object sender, EventArgs e)
        {
            _order.AddEnvelope = chkEnvelope.Checked;
            _order.AddStamp = chkStamp.Checked;
            UpdateUI();
        }

        private void chkCustom_CheckedChanged(object sender, EventArgs e)
        {
            _order.AddCustomMessage = chkCustom.Checked;
            txtMessage.Enabled = chkCustom.Checked;

            if (!chkCustom.Checked)
            {
                txtMessage.Text = string.Empty;
                _order.CustomMessage = null;
            }
            UpdateUI();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            _order.CustomMessage = txtMessage.Text;
            lblOverlay.Text = _order.AddCustomMessage ? _order.CustomMessage : string.Empty;
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblCost.Text = string.Format("Cost: ${0:0.00}", _order.Total());

            lblOverlay.Visible = _order.AddCustomMessage && !string.IsNullOrWhiteSpace(_order.CustomMessage);

            cboStyle.Enabled = (cboOccasion.SelectedItem != null);
        }
    }
}
