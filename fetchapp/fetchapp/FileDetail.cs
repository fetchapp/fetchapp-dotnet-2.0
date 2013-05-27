using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchAppAPI
{
    public struct FileDetail
    {
        public String FileID { get; set; }
        public String FileName { get; set; }
        public int SizeInBytes { get; set; }
        public String ContentType { get; set; }
        public String Permalink { get; set; }
        public String URL { get; set; }
    }
}
