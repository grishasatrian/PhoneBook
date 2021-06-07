using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Contact
{
    public partial class PhoneBook : Form
    {
        List<Contact> _contacts = new List<Contact>();
        int _selection = -1;
        public PhoneBook()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }
        // Adding contact
        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = input_name.Text;
            string email = input_email.Text;
            string phone = input_phone.Text;
            string address = input_address.Text;

            if(name.Length == 0)
            {
                MessageBox.Show("Please input name!");
                return;
            }
            if (email.Length == 0)
            {
                MessageBox.Show("Please input email!");
                return;
            }
            if (phone.Length == 0)
            {
                MessageBox.Show("Please input phone!");
                return;
            }
            if (address.Length == 0)
            {
                MessageBox.Show("Please input address!");
                return;
            }
            // Handling email validation
            Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool isValidEmail = regexEmail.IsMatch(input_email.Text);
            if (!isValidEmail)
            {
                MessageBox.Show("Please input valid Email");
                return;
            }
            // handling phone validation
            Regex regexPhone = new Regex(@"[0-9]");
            bool isValidPhone = regexPhone.IsMatch(input_phone.Text);
            if (!isValidPhone)
            {
                MessageBox.Show("Please input valid Phone number");
                return;
            }
            _contacts.Add(new Contact(name, email, phone, address));
            errorProviderEmail.Clear();
            errorProviderPhone.Clear();
            input_name.Text = "";
            input_email.Text = "";
            input_phone.Text = "";
            input_address.Text = "";
            ReloadGrid();
        }

        private void ReloadGrid()
        {
            int selRowNum = 1;
            var columns = from t in _contacts
                          select new
                          {
                              No = selRowNum++,
                              Name = t.Name,
                              Email = t.Email,
                              Phone = t.Phone,
                              Address = t.Address
                          };
            dataGridView1.DataSource = columns.ToList();
        }
        // Edit contact
        private void edit_btn_Click(object sender, EventArgs e)
        {
            string name = input_name.Text;
            string email = input_email.Text;
            string phone = input_phone.Text;
            string address = input_address.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("Please input name!");
                return;
            }
            if (email.Length == 0)
            {
                MessageBox.Show("Please input email!");
                return;
            }
            if (phone.Length == 0)
            {
                MessageBox.Show("Please input phone!");
                return;
            }
            if (address.Length == 0)
            {
                MessageBox.Show("Please input address!");
                return;
            }
            // Handling email validation
            Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool isValidEmail = regexEmail.IsMatch(input_email.Text);
            if (!isValidEmail)
            {
                MessageBox.Show("Please input valid Email");
                return;
            }
            // handling phone validation
            Regex regexPhone = new Regex(@"[0-9]");
            bool isValidPhone = regexPhone.IsMatch(input_phone.Text);
            if (!isValidPhone)
            {
                MessageBox.Show("Please input valid Phone number");
                return;
            }
            if (_selection >= 0)
            {
                _contacts[_selection].Name = name;
                _contacts[_selection].Email = email;
                _contacts[_selection].Phone = phone;
                _contacts[_selection].Address = address;
                ReloadGrid();

                input_name.Text = "";
                input_email.Text = "";
                input_phone.Text = "";
                input_address.Text = "";
                _selection = -1;
            }           
            else
            {
                MessageBox.Show("Please select a row");
            }
            errorProviderEmail.Clear();
            errorProviderPhone.Clear();
        }
        // Method to change contact in the grid
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection sel = dataGridView1.SelectedRows;
            if(sel.Count == 1)
            {
                _selection = sel[0].Index;

                input_name.Text = _contacts[_selection].Name;
                input_email.Text = _contacts[_selection].Email;
                input_phone.Text = _contacts[_selection].Phone;
                input_address.Text = _contacts[_selection].Address;
            }
        }
        // Remove contact
        private void del_btn_Click(object sender, EventArgs e)
        {
            if(_selection < 0)
            {
                MessageBox.Show("Please select a row");
                return;
            }
            else
            {
                _contacts.RemoveAt(_selection);
                ReloadGrid();
                _selection = -1;
            }
        }
        // Exit from program
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void input_email_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            if (Regex.IsMatch(input_email.Text, pattern))
            {
                errorProviderEmail.Clear();
            }
            else
            {
                errorProviderEmail.SetError(this.input_email, "Please input valid Email address");
                return;
            }
        }
        private void input_phone_Leave(object sender, EventArgs e)
        {
            string pattern = @"[0-9]";

            if (Regex.IsMatch(input_phone.Text, pattern))
            {
                errorProviderPhone.Clear();
            }
            else
            {
                errorProviderPhone.SetError(this.input_email, "Use only numbers");
                return;
            }
        }

       
    }
}
