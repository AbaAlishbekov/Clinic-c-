using DnaAnalysisApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnaAnalysisApp.BusinessLogic
{
    public class DnaAnalysisPerformer
    {
        private static char[] _dnaElements
            = new char[] { 'A', 'G', 'T', 'C' };
        public string PerformDnaPercentageAnalysis(Dna dna)
        {
            int [] occurenceCounter = new int [_dnaElements.Length];
            for (int i = 0; i < _dnaElements.Length; i++)
            {
                for (int j = 0; j < dna.DnaSequence.Length; j++)
                {
                    if (dna.DnaSequence[j]==_dnaElements[i])
                    {
                        occurenceCounter[i]++;
                    }
                    occurenceCounter[i]++;
                }
            }
            string returnString = String.Empty;
            for (int i = 0; i < _dnaElements.Length; i++)
            {
                returnString += $"Elements = {_dnaElements}, Occured Number = {occurenceCounter}";
            }
            return returnString;
        }
    }
}
