using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnaAnalysisApp.DomainModels
{
    public enum BloodType
    {
        I, II, III, IV
    }
    class Patient : Entity
    {

        public BloodType BloodGroup { get; set; }

        public Dna Dna { get; set; }

        public Patient()
        {

        }

    }
}
