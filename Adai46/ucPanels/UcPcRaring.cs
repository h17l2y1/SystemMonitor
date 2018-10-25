
using System.Windows.Forms;

namespace Adai46
{
    public partial class UcPcRaring : UserControl
    {
        TotalRating rating = new TotalRating();

        public UcPcRaring()
        {
            InitializeComponent();
            PrintRating();
        }

        private void PrintRating()
        {
            lbCpuRating.Text = rating.CpuRating;
            lbGpuRating.Text = rating.GpuRating;
            lbRamRating.Text = rating.RamRating;
        }
    }
}
