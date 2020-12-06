using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSampleLiveData
{
    public class News
    {
        public string Category { get; set; }
        public long datetime { get; set; }
        public string Headline { get; set; }
        public long Id { get; set; }
        public string Image { get; set; }
        public string Related { get; set; }
        public string Source { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }

        public DateTime PublishedDate
        {
            get
            {
                return DateTimeOffset.FromUnixTimeSeconds(datetime).DateTime;
            }
        }
    }

    public struct RowImage
    {
        public int RowHandle { get; set; }
        public Image Image { get; set; }
    }
}
