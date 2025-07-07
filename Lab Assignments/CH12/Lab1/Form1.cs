using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> _definitions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "variable", "A named memory location." },
            { "method", "A block of code that performs a task." },
            { "class", "A blueprint for creating objects." },
            { "namespace", "A container for classes and other namespaces." },
            { "property", "A member that provides access to a field." },
        };

        private TextBox txtTerm;
        private Button btnDefine;
        private Label lblResult;

        private Label lblNewPrompt;
        private TextBox txtNewDefinition;
        private Button btnAddDefinition;
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            // form
            this.Text = "Flash Cards";
            this.ClientSize = new Size(500, 250);

            // term input
            txtTerm = new TextBox { Location = new Point(20, 20), Width = 300 };
            this.Controls.Add(txtTerm);

            btnDefine = new Button { Text = "Define", Location = new Point(330, 18) };
            btnDefine.Click += BtnDefine_Click;
            this.Controls.Add(btnDefine);

            // result label
            lblResult = new Label
            {
                Location = new Point(20, 60),
                Width = 450,
                Height = 60,
                Font = new Font("Segoe UI", 10),
                AutoSize = false
            };
            this.Controls.Add(lblResult);

            // hidden controls for adding a new definition
            lblNewPrompt = new Label
            {
                Location = new Point(20, 130),
                Width = 450,
                Text = "I don't know that term yet. What does it mean?",
                Visible = false
            };
            this.Controls.Add(lblNewPrompt);

            txtNewDefinition = new TextBox
            {
                Location = new Point(20, 160),
                Width = 350,
                Visible = false
            };
            this.Controls.Add(txtNewDefinition);

            btnAddDefinition = new Button
            {
                Text = "Add",
                Location = new Point(380, 158),
                Visible = false
            };
            btnAddDefinition.Click += btnDefine_Click;
            this.Controls.Add(btnAddDefinition);
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
