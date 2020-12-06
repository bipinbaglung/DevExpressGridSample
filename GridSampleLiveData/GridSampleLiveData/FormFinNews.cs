using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridSampleLiveData
{
    public partial class FormFinNews : Form
    {
        private Timer dataFetchTimer;
        private DataFetcher dataFetcher;
        private int previewImageWidth = 150;
        private RowImage rowImage = new RowImage();
        private List<News> newsData;
        public FormFinNews()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataFetcher = new DataFetcher();
            dataFetcher.NewDataReceivedEventHandler += DataFetcher_newDataReceivedEventHandler;

            dataFetchTimer = new Timer();
            dataFetchTimer.Interval = 15000;
            dataFetchTimer.Tick += DataFetchTimer_Tick;
            gridViewNews.ShowLoadingPanel();
            DataFetchTimer_Tick(null, null);
            dataFetchTimer.Start();
        }

        private void DataFetcher_newDataReceivedEventHandler(List<News> data)
        {
            if (newsData == null) // first load
            {
                newsData = data;
                ShowLatestData();
            }
            else
            {
                newsData = data;
                simpleButtonShowLatestData.Visible = true;
            }
            gridViewNews.HideLoadingPanel();
        }

        private void DataFetchTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                dataFetcher.GetData();
            }
            catch (Exception ex)
            {
                string message = ex.Message + Environment.NewLine;
                while (ex.InnerException != null)
                {
                    message += ex.InnerException.Message + Environment.NewLine;
                    ex = ex.InnerException;
                }
                XtraMessageBox.Show(message, "Fetch Data");
            }
        }

        private void repositoryItemHyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.EditValue.ToString());
            }
            catch (Exception ex)
            {
                string message = ex.Message + Environment.NewLine;
                while (ex.InnerException != null)
                {
                    message += ex.InnerException.Message + Environment.NewLine;
                    ex = ex.InnerException;
                }
                XtraMessageBox.Show(message, "Fetch Data");
            }
        }

        private void gridViewNews_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e)
        {
            if (e.RowHandle != gridViewNews.FocusedRowHandle)
            {
                e.PreviewText = String.Empty;
                return;
            }
            e.PreviewText = CalculatePreviewText(e.RowHandle);
        }

        private string CalculatePreviewText(int rowHandle)
        {
            if (rowHandle < 0 || rowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                return string.Empty;

            string summary = gridViewNews.GetRowCellValue(rowHandle, "Summary").ToString();
            string source = gridViewNews.GetRowCellValue(rowHandle, "Source").ToString();
            string previewText = string.Format("Source: {0} " + Environment.NewLine + " {1} " + Environment.NewLine, source, summary);
            return previewText;
        }

        private void gridViewNews_CustomDrawRowPreview(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {

            if (e.RowHandle != gridViewNews.FocusedRowHandle)
            {
                e.Handled = true;
                return;
            }
            string text = CalculatePreviewText(e.RowHandle);
            var imageWidth = 0;
            if (rowImage.Image != null)
            {
                imageWidth = rowImage.Image.Width;
                e.Cache.DrawImage(rowImage.Image, e.Bounds.X + 2, e.Bounds.Y + 2, rowImage.Image.Width, rowImage.Image.Height);
            }
            Point textOrigin = new Point(e.Bounds.X + imageWidth + 20, e.Bounds.Y + 4);
            Rectangle textRect = new Rectangle(textOrigin.X, textOrigin.Y, e.Bounds.Width - textOrigin.X, e.Bounds.Height - 8);
            StringFormat format = e.Appearance.GetStringFormat();
            format.Trimming = StringTrimming.EllipsisWord;

            e.Cache.DrawString(text, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), textRect, format);
            e.Handled = true;
        }

        private Image GetRowImage(int rowHandle)
        {
            System.Diagnostics.Debug.WriteLine(rowHandle);

            var row = gridViewNews.GetRowCellValue(rowHandle, "Image");
            if (row == null || string.IsNullOrWhiteSpace(row.ToString()))
                return null;


            string uri = row.ToString();
            try
            {
                Image image = dataFetcher.GetImage(uri);
                return ResizeImage(image, previewImageWidth);
            }
            catch (Exception ex)
            {
                string message = ex.Message + Environment.NewLine;
                while (ex.InnerException != null)
                {
                    message += ex.InnerException.Message + Environment.NewLine;
                    ex = ex.InnerException;
                }
                XtraMessageBox.Show(message, "Fetch Data");
                return null;
            }
        }

        private Image ResizeImage(Image highResolutionImage, int maxWidth)
        {
            int lpixheight, lpixwidth;
            double lscale;
            int lheight = highResolutionImage.Height;
            int lwidth = highResolutionImage.Width;
            if (lheight > lwidth)
            {
                lscale = (double)maxWidth / lheight;
                lpixheight = maxWidth;
                lpixwidth = Convert.ToInt32(lwidth * lscale);
            }
            else
            {
                lscale = (double)maxWidth / lwidth;
                lpixwidth = maxWidth;
                lpixheight = Convert.ToInt32(lheight * lscale);
            }

            Bitmap newImage = new Bitmap(lpixwidth, lpixheight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(highResolutionImage, 0, 0, lpixwidth, lpixheight);
            }
            return newImage;
        }

        private void gridViewNews_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridViewNews.ShowLoadingPanel();
            GridView view = (GridView)(sender as GridView);
            view.LayoutChanged();
        }

        private void gridViewNews_MeasurePreviewHeight(object sender, RowHeightEventArgs e)
        {
            gridViewNews.ShowLoadingPanel();
            if (e.RowHandle == gridViewNews.FocusedRowHandle)
            {
                if (e.RowHandle != rowImage.RowHandle || rowImage.Image == null)
                    rowImage.Image = GetRowImage(e.RowHandle);
                rowImage.RowHandle = e.RowHandle;
                if (rowImage.Image != null)
                    e.RowHeight = rowImage.Image.Height + 5;
                else e.RowHeight = 40;
            }
            else e.RowHeight = 0;
            gridViewNews.HideLoadingPanel();
        }

        private void simpleButtonShowLatestData_Click(object sender, EventArgs e)
        {
            ShowLatestData();
        }

        private void ShowLatestData()
        {
            simpleButtonShowLatestData.Visible = false;
            gridControlNews.DataSource = newsData;
            gridControlNews.RefreshDataSource();
            gridViewNews.HideLoadingPanel();
        }
    }
}
