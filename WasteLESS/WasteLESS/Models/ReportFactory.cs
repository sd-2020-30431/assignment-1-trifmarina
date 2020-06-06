using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WasteLESS.Models
{

    public abstract class ItemReport
    {
        protected int _nrOfItems;
        public abstract int NrOfItems { get; set; }
    }



    public abstract class ReportFactory 
    {
        public abstract ItemReport CreateItemReport(int a, int b);
    }

    public class ExpirationItemReport : ItemReport
    {
        protected int _nrOfExpiredItems;
        protected int _nrOfExpiredItemsBeforeCons;

        public ExpirationItemReport(int ne, int neb)
        {
            _nrOfExpiredItems = ne;
            _nrOfExpiredItemsBeforeCons = neb;
        }
        public override int NrOfItems
        {
            get{
                return _nrOfItems;
            }
            set
            {
                _nrOfItems = value;
            }
        }

        public int NrOfExpiredItems
        {
            get
            {
                return _nrOfExpiredItems;
            }
            set
            {
                _nrOfExpiredItems = value;
            }
        }

        public int NrOfExpiredItemsBeforeCons
        {
            get
            {
                return _nrOfExpiredItemsBeforeCons;
            }
            set
            {
                _nrOfExpiredItemsBeforeCons = value;
            }
        }
    }

    public class ItemReportFactory : ReportFactory
    {
        public override ItemReport CreateItemReport(int n1, int n2)
        {
            return new ExpirationItemReport(n1,n2);    
        }

      
    }
}
