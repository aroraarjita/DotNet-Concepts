using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializationAndDeserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                name = txtBoxName.Text,
                phone = txtBoxPhone.Text,
                dob = dateTimePickerDoB.Value,
                department = txtBoxDepartment.Text,
                salary = Convert.ToInt32(txtBoxSalary.Text),
                additionalInfo = "We don't want it to serialize"
            };

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream("employee.binary", 
                FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, emp);
                    label6.Text = "Object Serialized";
                   
                }

            }
            catch
            {
                label6.Text = "An error has occured";

            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("employee.binary", 
                FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fsin)
                {
                    emp = (Employee)bf.Deserialize(fsin);
                    label6.Text = "Object Deserialized";

                    txtBoxName.Text = emp.name;
                    txtBoxPhone.Text = emp.phone;
                    dateTimePickerDoB.Value = emp.dob;
                    txtBoxDepartment.Text = emp.department;
                    txtBoxSalary.Text = emp.salary.ToString();

                }

            }
            catch
            {
                label6.Text = "An error has occurred";
            }
        }
    }
}
