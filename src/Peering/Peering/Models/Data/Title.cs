using System;
using System.Collections.Generic;
using System.Text;

namespace TeamFoundationServerPowershell.Model.Data
{
    public class Title
    {
        public string Command { get; set; }

        public string CompanyName { get; set; }

        public int PeerAsn { get; private set; }

        public string Other { get; set; }

        public string Operation { get; set; }

        public int WorkItem { get; private set; }

        public Title(string titleField, int workItem)
        {
            var arr = titleField.Replace("]", string.Empty).Split('[');
            this.Command = arr[1];
            this.CompanyName = arr[2];
            this.PeerAsn = int.Parse(arr[3].ToUpperInvariant().TrimStart('A', 'S', 'N'));
            this.Other = arr[4];
            this.Operation = arr[5];
            this.WorkItem = workItem;
        }
    }
}
