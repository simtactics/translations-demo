// This project is licensed under the MPL-2.0 license.
// See the LICENSE file in the project root for more information.
using System;
using System.IO;
using System.Windows.Forms;
using Sixam.CST;

namespace TranslationDemo.Forms
{
    public partial class DemoWin : Form
    {
        public DemoWin()
        {
            InitializeComponent();

            var uitextDir = Path.Combine(AppContext.BaseDirectory, "uitext");
            if (!Directory.Exists(uitextDir))
                MessageBox.Show($@"Unable to locate {uitextDir}");
        }

        void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var text = new UIText(langTxtBox.Text.ToLowerInvariant());
                if (int.TryParse(idTxtBox.Text, out int value))
                    sampleTxtBox.Text = text.GetText(value, keyTxtBox.Text);
            }
            catch (Exception err)
            {
                sampleTxtBox.Text = err.Message;
            }
        }
    }
}
