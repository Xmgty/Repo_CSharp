using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Simplecrypt
{
    public partial class MainForm : Form
    {

        private String KeyText = "";
        private String FilePath = "";

        public MainForm()
        {
            InitializeComponent();
            openFileDialog.FileName = "";
        }

        private void FileTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FileTextBox.Text != null)
            {
                this.FilePath = FileTextBox.Text;
            }
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyTextBox.Text != null)
            {
                this.KeyText = KeyTextBox.Text;
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files (*.*)|*.*|Encrypted Files (*.des)|*.des";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                FileTextBox.Text = openFileDialog.FileName;
            this.Invalidate();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncryptFile();
            this.Invalidate();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            DecryptFile();
            this.Invalidate();
        }

        private void EncryptFile()
        {
            string inName = this.FilePath;
            string outName = this.FilePath + ".des";    
            byte[] desKey = this.keytoByteArray();
            byte[] desIV = this.keytoByteArray();

            using (FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read))
            using (FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fout.SetLength(0);

             
                byte[] bin = new byte[100];     
                long rdlen = 0;                 
                long totlen = fin.Length;        
                int len;                        

                DES des = new DESCryptoServiceProvider();
                CryptoStream encStream = new CryptoStream(fout, des.CreateEncryptor(desKey, desIV), CryptoStreamMode.Write);

                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    encStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.WriteLine(KeyTextBox.Text);
                    streamWriter.Close();
                }

                
                encStream.Close();
                MessageBox.Show("Шифровка завершена.");
                fout.Close();
                fin.Close();
            }
        }

        private void DecryptFile()
        {
            string inName = this.FilePath;
            string outName = Path.ChangeExtension(FilePath, "");

            byte[] desKey = this.keytoByteArray();
            byte[] desIV = this.keytoByteArray();


            using (FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read))
            using (FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write))
            {

                fout.SetLength(0);
                byte[] bin = new byte[100];     
                long rdlen = 0;                  
                long totlen = fin.Length;       
                int len;                        

                DES des = new DESCryptoServiceProvider();
                CryptoStream decStream = new CryptoStream(fout, des.CreateDecryptor(desKey, desIV), CryptoStreamMode.Write);

                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    decStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }

                
                decStream.Close();
                MessageBox.Show("Расшифровка завершена.");
                fout.Close();
                fin.Close();
            }
        }

        private byte[] keytoByteArray()
        {
            byte[] KeyArray = Enumerable.Repeat((byte)0, 8).ToArray();

            for (int i = 0; i < KeyText.Length; i++)
            {
                byte b = (byte)KeyText[i];
                KeyArray[i % 8] = (byte)(KeyArray[i % 8] + b);
            }

            return KeyArray;
        }

        public bool overwriteifExist(string outName)
        {
            if (File.Exists(outName))
            {
                var result = MessageBox.Show("Файл с таким именем уже существует, перезаписать?",
                "Ошибка",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes) return true;
                else return false;
            }
            return true;
        }
    }
}

