using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnaAnalysisApp.DomainModels
{
    public  class Dna : Record
    {

        private static int _dnaLength;
        private static char[] _dnaElements;
        public static int DnaElementsCount => _dnaElements.Length;
        #region Propoties
        public string DnaSequence { get; set; }

        #endregion

        
        public Dna()
        {
            DnaSequence = GenerateDnaSequence();
        }
        static Dna()
        {
            _dnaElements = new char[4] { 'A', 'G', 'T', 'C' };
            _dnaLength = 10000;
        }
        #region Methods
        private static string GenerateDnaSequence()
        {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            string generatedSequence = String.Empty;
            for (int i = 0; i < _dnaLength; i++)
            {
                sb.Append(_dnaElements[rand.Next(0, _dnaElements.Length)]);
            }
            return sb.ToString();
        }

        #endregion
    }
}
