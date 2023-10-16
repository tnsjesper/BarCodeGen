
using QRCoder;
using System.Windows.Forms;

namespace BarCodeGen
{
    public partial class BarCodeGenerator : Form
    {
        public BarCodeGenerator()
        {
            InitializeComponent();
        }

        private void BTNGenerate_Click(object sender, EventArgs e)
        {


            QRCoder.QRCodeGenerator QRGen = new QRCoder.QRCodeGenerator();
            var QRData = QRGen.CreateQrCode(TextBox.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRcode = new QRCoder.QRCode(QRData);

            PicBoxBarCode.Image = QRcode.GetGraphic(10);
        }

        private void PicBoxBarCode_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (PicBoxBarCode.Image == null) { return; }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { FileName = "qrcode.png" })

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PicBoxBarCode.Image.Save(saveFileDialog.FileName);
                }


        }
    }
}