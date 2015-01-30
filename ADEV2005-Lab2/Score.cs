using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADEV2005Lab2
{

    public class Score
    {
        public enum ItemScore
        {
            BelowStandard,
            MeetsMinimumStandard,
            MeetsStandard
        }
        public ItemScore Comments { get; set; }
        public ItemScore NamingConventions { get; set; }
        public ItemScore UnitTests { get; set; }
        public bool Crash { get; set; }
        public int FunctionalErrors { get; set; }
        public int InterfaceErrors { get; set; }

        public Score(ItemScore comments, ItemScore namingConventions, ItemScore unitTests, bool crash, int functionalErrors, int interfaceErrors)
        {
            this.Comments = comments;
            this.NamingConventions = namingConventions;
            this.UnitTests = unitTests;
            this.Crash = crash;
            this.FunctionalErrors = functionalErrors;
            this.InterfaceErrors = interfaceErrors;
        }

        public ItemScore CalculateScore()
        {
            int meetsMinimum = 0;
            ItemScore score = (Crash) ? ItemScore.BelowStandard : ItemScore.MeetsMinimumStandard;
            ItemScore[] props = { Comments, NamingConventions, UnitTests, getItemScore(FunctionalErrors), getItemScore(InterfaceErrors) };
            // exit variable for the loop.
            // can be set to Crash because if crash it true, we don't need to loop
            // bool isBelowStandard = Crash;
            foreach (ItemScore el in props)
            {
                if (score == ItemScore.BelowStandard)
                {
                    break;
                }
                switch (el)
                {
                    case ItemScore.MeetsMinimumStandard:
                        meetsMinimum++;
                        break;
                    case ItemScore.BelowStandard:
                        score = ItemScore.BelowStandard;
                        break;

                }
            }
            if (score != ItemScore.BelowStandard)
            {
                if (meetsMinimum >= 3)
                {
                    score = ItemScore.BelowStandard;
                }
                else if (meetsMinimum == 2)
                {
                    score = ItemScore.MeetsMinimumStandard;
                }
                else
                {
                    score = ItemScore.MeetsStandard;
                }
            }
            return score;
        }

        private ItemScore getItemScore(int numberOfErrors)
        {
            ItemScore score;
            switch (numberOfErrors)
            {
                case 0:
                    score = ItemScore.MeetsStandard;
                    break;
                case 1:
                    score = ItemScore.MeetsMinimumStandard;
                    break;
                default:
                    score = ItemScore.BelowStandard;
                    break;
            }
            return score;
        }
    }
}
