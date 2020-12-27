using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab6
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private FileInfo fiSource;
        private string fileName;
        private FileStream fsSource; 
        private StreamReader srSource; 
        private StreamWriter swSource; 

        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            fileName = tbInput.Text;
            fiSource = new FileInfo(fileName);
            tbInfo.Clear();
            tbEdit.Clear();
            tbInput.Clear();
            try
            {
                if (fiSource.Exists)
                {
                    lblFilename.Text = "Информация о файле: " + fileName;
                    tbInfo.Text += "Время создания файла: " +
                    fiSource.CreationTime.ToString() + "\r\n";
                    tbInfo.Text += "Размер файла " + fiSource.Length + " байт \r\n";
                    tbInfo.Text += "Полный путь к файлу: " + fiSource.FullName.ToString() + "\r\n";
                }
            }
            catch (IOException ex) 
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString());
            }
            if (Path.GetExtension(fileName) == ".txt")
            {
                btnSave.Enabled = true;
                tbEdit.ReadOnly = false;
                fsSource = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                srSource = new StreamReader(fsSource);
                string line;
                line = srSource.ReadLine(); 
                while (line != null) 
                {
                    tbEdit.Text += line + "\r\n"; 
                    line = srSource.ReadLine(); 
                }
                srSource.Close(); 
            }
            else
            {
                tbEdit.Text += "Файл не является текстовым";
                btnSave.Enabled = false;
                tbEdit.ReadOnly = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                fsSource = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                swSource = new StreamWriter(fsSource);
                for (int i = 0; i < tbEdit.Lines.Length; i++)
                {
                    swSource.WriteLine(tbEdit.Lines[i]);
                }
                swSource.Close(); 
                MessageBox.Show("Изменения сохранены!");
            }
            catch (IOException ex) 
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Произошла доступа: " + ex.ToString());
            }
        }
    }
}
