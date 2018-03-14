using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnaAnalysisApp.DomainModels
{
   public abstract class Record
    {
        #region Properties
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        #endregion



        public Record()
        {
            IsDeleted = false;
        }
    }

}
