using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            gvTowns.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Brand";
            column.Name = "Марка";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Color";
            column.Name = "Колiр";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Memory";
            column.Name = "Об'єм пам'ятi";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Year";
            column.Name = "Рiк випуску";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SizeDisplay";
            column.Name = "Дiагональ";
            column.Width = 80;
            gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Bluetooth";
            column.Name = "Блютуз";
            column.Width = 60;
            gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "NFC";
            column.Name = "NFC";
            column.Width = 60;
            gvTowns.Columns.Add(column);

            bindSrcTowns.Add(new Tablet("Apple", "Ipad pro", "Silver", 128, 2020, 10, true, false));
            EventArgs args = new EventArgs();
            OnResize(args);
        }

        
            

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
           

        }

        private void bindSrcTowns_CurrentChanged(object sender, EventArgs e)
        {
            
           


        }

        private void gvTowns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Tablet tablet = new Tablet();
            fTablet ft = new fTablet( tablet);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.Add(tablet);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Tablet tablet = (Tablet)bindSrcTowns.List[bindSrcTowns.Position];
            fTablet ft = new fTablet(tablet);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.List[bindSrcTowns.Position] = tablet;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
            "Видалення запису", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTowns.RemoveCurrent();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            "Очистити таблицю?\n\nВсі дані будуть втрачені",
            "Очищення даних", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
