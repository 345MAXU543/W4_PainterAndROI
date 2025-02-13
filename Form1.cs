using System.Drawing;
using System.Drawing.Imaging;

namespace W4_PainterAndROI
{
    public partial class frmMain : Form
    {

        private bool bBeginDraged = false;
        private int iXx, iXy, iXx1, iXy1;
        private int xPos;
        private int yPos;
        private Color PanColor;
        
        public frmMain()
        {
            InitializeComponent();
            //捕捉滾輪事件
            this.imgPicbox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseWheel);
            this.txtSizeWidth.Text = imgPicbox.Image.Width.ToString();
            this.txtSizeheigh.Text = imgPicbox.Image.Height.ToString();
            btnPanColor1.BackColor = Color.Black;
            PanColor = btnPanColor1.BackColor;
            btnRedColor.Click += new EventHandler(fnBtnChooseColor);
            btnOringeColor.Click += new EventHandler(fnBtnChooseColor);
            btnYellowColor.Click += new EventHandler(fnBtnChooseColor);
            btnGreenColor.Click += new EventHandler(fnBtnChooseColor);
            btnBlueColor.Click += new EventHandler(fnBtnChooseColor);
            tabCanvaSize.Parent = null;
        }

        private void fnBtnChooseColor(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btnPanColor1.BackColor = btn.BackColor;

        }

        private void Pic_MouseWheel(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic != null && pic.Image != null)
            {
                // 設定縮放比例
                float scaleFactor = 1.1f;
                if (e.Delta < 0) // 滾輪向下滾動
                {
                    scaleFactor = 1 / scaleFactor;
                }

                // 計算新的圖片大小
                int newWidth = (int)(pic.Image.Width * scaleFactor);
                int newHeight = (int)(pic.Image.Height * scaleFactor);

                // 縮放圖片
                Bitmap newImage = new Bitmap(pic.Image, newWidth, newHeight);
                pic.Image = newImage;
            }
        }

        private void imgPicbox_MouseEnter(object sender, EventArgs e)
        {
            imgPicbox.Focus();
        }
        bool isDrawing = false;
        Point lastPoint;
        private void imgPicbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                Color colorVar;
                if (bNowIsPen == true && bNowIsEraser == false)
                {
                    colorVar = btnPanColor1.BackColor;
                }
                else
                {
                    colorVar = Color.White;
                }
                using (Graphics g = Graphics.FromImage(imgPicbox.Image))
                {
                    using (Pen pen = new Pen(colorVar, Convert.ToInt32(txtPanSize.Text)))
                    {
                        g.DrawEllipse(pen, e.X- Convert.ToInt32(txtPanSize.Text)/2, e.Y- Convert.ToInt32(txtPanSize.Text)/2, Convert.ToInt32(txtPanSize.Text), Convert.ToInt32(txtPanSize.Text));  // 繪製線條
                    }
                }

                lastPoint = e.Location;  // 更新上次位置
                imgPicbox.Invalidate(); // 強制重新繪製 PictureBox
            }
            try
            {

                if (((imgPicbox.Width - this.Width) <= 0 || (imgPicbox.Height - this.Height) <= 0) && (e.Button == MouseButtons.Middle))
                {
                    imgPicbox.Left += Convert.ToInt16(e.X - xPos);
                    imgPicbox.Top += Convert.ToInt16(e.Y - yPos);
                    //if ((imgPicbox.Top + Convert.ToInt16(e.Y - yPos)) <= 0
                    //    || (imgPicbox.Left + Convert.ToInt16(e.X - xPos)) <= 0
                    //    || (imgPicbox.Right + Convert.ToInt16(e.X - xPos)) >= this.Width
                    //    || (imgPicbox.Bottom + Convert.ToInt16(e.Y - yPos)) >= this.Height)
                    //{

                    //}
                }

            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
            }
        }

        private void imgPicbox_MouseDown(object sender, MouseEventArgs e)
        {
            xPos = e.X;
            yPos = e.Y;
            bBeginDraged = true;
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void imgPicbox_MouseUp(object sender, MouseEventArgs e)
        {
            bBeginDraged = false;
            isDrawing = false;
        }

        private void txtSizeWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fnChangeCanvaSize();
            }
        }

        private void txtSizeheigh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fnChangeCanvaSize();
            }
        }

        private void fnChangeCanvaSize()
        {
            if (int.TryParse(txtSizeWidth.Text, out int iNewWidth) && int.TryParse(txtSizeheigh.Text, out int iNewHeight))
            {
                if (iNewWidth > 0 && iNewHeight > 0)
                {
                    if (imgPicbox.Image != null)
                    {
                        // 調整圖片大小
                        Bitmap newImage = new Bitmap(imgPicbox.Image, iNewWidth, iNewHeight);
                        imgPicbox.Image = newImage;
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的寬度和高度。");
            }
        }

        private void itmCanvaSize_Click(object sender, EventArgs e)
        {

        }

        private void btnPanColor1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            btnPanColor1.BackColor = cd.Color;
            PanColor = btnPanColor1.BackColor;
        }

        private void barPanSize_Scroll(object sender, EventArgs e)
        {
            txtPanSize.Text = barPanSize.Value.ToString();
            Bitmap bitmap2 = new Bitmap("D:\\新訓\\每周\\W4_PainterAndROI\\Properties\\iconCursor.png");
            Bitmap bitmap = new Bitmap(bitmap2, barPanSize.Value*2,barPanSize.Value*2);
            imgPicbox.Cursor = new Cursor(bitmap.GetHicon());
        }

        private void btnCanvaSize_Click(object sender, EventArgs e)
        {
            fnTabInvisible();
            tabCanvaSize.Parent = ctrlTab;
        }
        private void fnTabInvisible()
        {
            tabCanvaSize.Parent = null;
            tabPanSetting.Parent = null;
        }

        private void btnPanSize_Click(object sender, EventArgs e)
        {
            fnTabInvisible();
            tabPanSetting.Parent = ctrlTab;
        }

        private void btnStpOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                imgPicbox.Image = new Bitmap(filePath);
            }
        }

        private void btnStpEraser_Click(object sender, EventArgs e)
        {
            bNowIsPen = false;
            bNowIsEraser = true;
            fnTabInvisible();
            tabPanSetting.Parent = ctrlTab;
        }
        bool bNowIsPen = true;
        bool bNowIsEraser = false;
        private void btnStpPen_Click(object sender, EventArgs e)
        {
            bNowIsPen = true;
            bNowIsEraser = false;
            fnTabInvisible();
            tabPanSetting.Parent = ctrlTab;


        }

        private void btnToolStpNew_Click(object sender, EventArgs e)
        {
            imgPicbox.Image = new Bitmap(@"D:\\新訓\\每周\\W4_PainterAndROI\\Properties\\Wbackground (小).png");
        }

        private void btnToolStpMenuNEW_Click(object sender, EventArgs e)
        {
            imgPicbox.Image = new Bitmap(@"D:\\新訓\\每周\\W4_PainterAndROI\\Properties\\Wbackground (小).png");
        }

       
    }

}
