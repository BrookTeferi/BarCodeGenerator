using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BarCodeGenerator.Models
{
    public class GenerateBarcodeModel
    {
        [Display(Name = "Enter Barcode Text")]
        public string BarcodeText
        {
            get;
            set;
        }
    }
}