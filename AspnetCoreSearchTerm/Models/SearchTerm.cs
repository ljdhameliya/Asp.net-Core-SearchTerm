using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreSearchTerm.Models
{
    public class SearchTerm
    {
        public int ID { get; set; }
        public string SearchKeyword { get; set; }
        public Enum_SearchBarFieldType SearchBarFieldType { get; set; }
        public Enum_PageSearchEntered PageSearchEnter { get; set; }
        public int? SearchSequence { get; set; }
        public DateTime SearchDateTime { get; set; }
        public string SearchByUser { get; set; }
    }
    public enum Enum_SearchBarFieldType
    {
        SearchText = 1,
        Location = 2,
        Category = 3,
        ListingType = 4,
        PriceLow = 5,
        PriceHigh = 6
    }
    public enum Enum_PageSearchEntered
    {
        HomePage = 1,
        MainPage = 2
    }
}
