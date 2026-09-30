using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorFactory.SpaceSnoop
{
    public class DirectorySpace()
    {
        public string Name { get; set; }
        /// <summary>
        /// Размер файликов без подпапок.
        /// </summary>
        public long Size { get; set; }
        /// <summary>
        /// Размер всех файликов, включая дочерние подпапки. 
        /// </summary>
        public long TotalSize { get; set; }
        public string TotalSizeText { 
            get {
                return SizeSuffix(TotalSize);
            } 
        }
        public List<DirectorySpace> SubDirs { get; set; }

        public string[] SizeSuffixes = {"bytes", "KB", "MB", "GB", "TB" };

        private string SizeSuffix(long value, int decimalPlaces = 1) {
            if(value < 0) {
                return "-" + SizeSuffix(-value, decimalPlaces);
            }

            int i = 0;
            decimal dValue = (decimal)value;
            while (Math.Round(dValue, decimalPlaces) >= 1000) {
                dValue /= 1024;
                i++;
            }
            return string.Format("{0:n" + decimalPlaces + "} {1}", dValue, SizeSuffixes[i]);
        }
    }
}
