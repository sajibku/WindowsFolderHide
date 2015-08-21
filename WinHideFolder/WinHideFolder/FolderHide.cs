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
using System.Drawing.Drawing2D;

namespace WinHideFolder
{
    public partial class FolderHide : Form
    {
        DirectoryInfo ch;
        string []gtext = new string[100];
        int i = 0;
        public FolderHide()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    text = openFileDialog1.FileName;
                    gtext[i] = text;
                    i++;
                }
                ch = new DirectoryInfo(text);
                ch.Attributes = FileAttributes.Hidden;
                MessageBox.Show("Hidden");
            }
            catch { };
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               // string text = "J:" + @"\";

                /* try
                 {
                     i--;
                    // ch = new DirectoryInfo(txtFilePath.Text);
                     if (i >= 0)
                     {
                         ch = new DirectoryInfo(gtext[i]);
                
                         ch.Attributes = FileAttributes.Normal;
                         MessageBox.Show("Visible");
                     }
                     MessageBox.Show("Nothing is hide!!!");
                
                 }
                 catch { MessageBox.Show("error"); }*/
                //ch = new DirectoryInfo(text);
                //ch.Attributes = FileAttributes.Hidden;
               // MessageBox.Show("Hidden");
                DirectoryInfo d = new DirectoryInfo(@"J:\");//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles(); //Getting Text files
                string[] dirs = Directory.GetDirectories(@"J:\");
                string str = "";
                foreach (FileInfo file in Files)
                {
                     str = str + ", " + file.Name;
                     MessageBox.Show(str);
                    file.Attributes= FileAttributes.Hidden;
                    
                }
                foreach (string dir in dirs)
                {
                    MessageBox.Show(dir);
                    ch = new DirectoryInfo(dir);
                    ch.Attributes = FileAttributes.Hidden;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }
        private void itemSelected()
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
           
        }

        private void FolderHide_Load(object sender, EventArgs e)
        {
            timer1.Start();
          // MyGrid grid = new MyGrid();
           // this.Controls.Add(grid);

           /* MyGrid dataGridView1 = new MyGrid();
            this.Controls.Add(dataGridView1);

            dataGridView1.BackgroundImage = Properties.Resources.EVIveEN;
            dataGridView1.SetCellsTransparent();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string text = "";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    text = folderBrowserDialog1.SelectedPath;
                    MessageBox.Show(text);
                    gtext[i] = text;
                    i++;
                    //txtFilePath.Text = folderBrowserDialog1.SelectedPath;
                }
                ch = new DirectoryInfo(text);
                ch.Attributes = FileAttributes.Hidden;
                MessageBox.Show("Hidden");
            }
            catch { }
           
        }

        private void itemSele(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Website ws = new Website();
            ws.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Website ws = new Website();
            ws.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt"); 
        }

        private void mEnterw(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.CadetBlue;
        }

        private void mLeavew(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.White;
        }

        private void mEnters(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void mLeaves(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
       
    }

  /*  public class MyGrid : DataGridView
    {
        private Image _backgroundPic;

        [Browsable(true)]
        public override Image BackgroundImage
        {
            get { return _backgroundPic; }
            set { _backgroundPic = value; }
        }

        protected override void PaintBackground(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);

            if (((this.BackgroundImage != null)))
            {
                graphics.FillRectangle(Brushes.Black, gridBounds);
                graphics.DrawImage(this.BackgroundImage, gridBounds);
            }
        }

        //Make BackgroundImage can be seen in all cells
        public void SetCellsTransparent()
        {
            this.EnableHeadersVisualStyles = false;

            this.ColumnHeadersDefaultCellStyle.BackColor = Color.Transparent;

            this.RowHeadersDefaultCellStyle.BackColor = Color.Transparent;

            foreach (DataGridViewColumn col in this.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.Transparent;
            }
        }
    }*/
}
