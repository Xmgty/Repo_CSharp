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

namespace Store
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPhone.SelectedItem != null)
            {
                Phone my = (Phone)lstPhone.SelectedItem;
                Repository.Phones.Remove(my);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstPhone != null)
            {
                Repository.Phones.Clear();
            }
        }

        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            if (tbModel.Text == String.Empty || tbOS.Text == String.Empty || tbCPU.Text == String.Empty || tbPrice.Text == String.Empty)
            {
                MessageBox.Show("Ни одно поле для нового телефона не может быть пустым!");
            }
            else
            {
                try
                {
                    Phone phone = new Phone()
                    {
                        Model = tbModel.Text,
                        OS = tbOS.Text,
                        CPU = tbCPU.Text,
                        Price = decimal.Parse(tbPrice.Text),
                        MyImage = new Bitmap(tbImage.Text)

                    };
                    phone.Options = new BindingList<Option>();
                    for (int i = 0; i < lstOptionsNewPhone.Items.Count; i++)
                    {
                        if (lstOptionsNewPhone.GetItemChecked(i))
                        {
                            Option option = new Option() { Name = lstOptionsNewPhone.GetItemText(lstOptionsNewPhone.Items[i]) };
                            phone.Options.Add(option);
                        }

                    }
                    Repository.Phones.Add(phone);
                    lstPhone.DataSource = Repository.Phones;

                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void lstPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbModelPhone.Text = ((Phone)lstPhone.SelectedItem).Model;
            tbOSPhone.Text = ((Phone)lstPhone.SelectedItem).OS;
            tbCPUPhone.Text = ((Phone)lstPhone.SelectedItem).CPU;
            tbPricePhone.Text = ((Phone)lstPhone.SelectedItem).Price.ToString();
            lstOption.DataSource = ((Phone)lstPhone.SelectedItem).Options;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = ((Phone)lstPhone.SelectedItem).MyImage;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbModel.Clear();
            tbOS.Clear();
            tbCPU.Clear();
            tbPrice.Clear();
            tbNameOption.Clear();
            tbImage.Clear();
            for (int i = 0; i < lstOptionsNewPhone.Items.Count; i++)
            {
                if (lstOptionsNewPhone.GetItemChecked(i))
                {
                    lstOptionsNewPhone.SetItemChecked(i, false);
                }
            }
        }

        private void btnOptionAdd_Click(object sender, EventArgs e)
        {
            if (tbNameOption.Text == String.Empty)
            {
                MessageBox.Show("Поле для новой опции не заполнено!");
            }
            else
            {
                Option option = new Option()
                {
                    Name = tbNameOption.Text
                };
                Repository.Opt.Add(option);
                lstOptionsNewPhone.DataSource = Repository.Opt;

            }
        }

        private void btnOptionDelete_Click(object sender, EventArgs e)
        {
            if (lstOptionsNewPhone.SelectedItem != null)
            {
                Option option = (Option)lstOptionsNewPhone.SelectedItem;
                Repository.Opt.Remove(option);
            }

            lstPhone_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using (FileStream file = new FileStream("file.txt", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, Repository.Phones); // сериализация
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream file = new FileStream("file.txt", FileMode.Open))
                {
                    BinaryFormatter binFormat = new BinaryFormatter();
                    Repository.Phones = (BindingList<Phone>)binFormat.Deserialize(file); // десериализация ! Обязательнао должно быть приведение типа
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            lstPhone.DataSource = Repository.Phones;
            lstOptionsNewPhone.DataSource = Repository.Opt;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lstPhone.DataSource = Repository.Phones;
            lstOptionsNewPhone.DataSource = Repository.Opt;

        }

        private void btnSaveChanched_Click(object sender, EventArgs e)
        {
            using (FileStream file = new FileStream("fileoption.txt", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, Repository.Opt); // сериализация
            }
        }
    }

}