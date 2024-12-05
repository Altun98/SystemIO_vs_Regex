using System.Drawing.Imaging;

namespace PrtScr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string screenPath = @"C:\Users\PC\Desktop\DersTest";
            string fileName=(DateTime.Now.Day).ToString()+(DateTime.Now.Month).ToString()+(DateTime.Now.Year).ToString()+(DateTime.Now.Second).ToString()+".png";
            string filePath = Path.Combine(screenPath, fileName);
            Bitmap ScrImage= new Bitmap(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
            Graphics gr=Graphics.FromImage(ScrImage);
            gr.CopyFromScreen(0,0,0,0,new Size(ScrImage.Width, ScrImage.Height));
            pictureBox1.Image = ScrImage;
            ScrImage.Save(filePath, ImageFormat.Png);
           
            MessageBox.Show("Yekunlasdi");

        }
    }
}
