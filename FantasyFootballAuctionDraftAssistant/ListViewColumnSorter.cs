using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballAuctionDraftAssistant
{
    public class ListViewColumnSorter : IComparer
    {
        public int SortColumn { get; set; }
        public SortOrder Order { get; set; }

        public ListViewColumnSorter()
        {
            SortColumn = 0;
            Order = SortOrder.None;
        }
        public int Compare(object x, object y)
        {
            int compareResult = 0;
            ListViewItem listViewX = (ListViewItem)x;
            ListViewItem listViewY = (ListViewItem)y;

            // Check if the items have the necessary sub-items
            if (SortColumn < listViewX.SubItems.Count && SortColumn < listViewY.SubItems.Count)
            {
                // Check if the content is a number
                if (double.TryParse(listViewX.SubItems[SortColumn].Text, out double numberX)
                    && double.TryParse(listViewY.SubItems[SortColumn].Text, out double numberY))
                {
                    // Numeric comparison
                    compareResult = numberX.CompareTo(numberY);
                }
                else
                {
                    // String comparison
                    compareResult = String.Compare(listViewX.SubItems[SortColumn].Text, listViewY.SubItems[SortColumn].Text);
                }

                if (Order == SortOrder.Ascending)
                {
                    return compareResult;
                }
                else if (Order == SortOrder.Descending)
                {
                    return (-compareResult);
                }
            }
            return 0;
        }

        //public int Compare(object x, object y)
        //{
        //    int compareResult;
        //    ListViewItem listViewX = (ListViewItem)x, listViewY = (ListViewItem)y;

        //    compareResult = String.Compare(listViewX.SubItems[SortColumn].Text, listViewY.SubItems[SortColumn].Text);

        //    if (Order == SortOrder.Ascending)
        //    {
        //        return compareResult;
        //    }
        //    else if (Order == SortOrder.Descending)
        //    {
        //        return (-compareResult);
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }

}
