using System;
using System.Collections.Generic;
using System.Text;

enum EQuestType
{
    QUESTTYPE_MAIN = 0,
    QUESTTYPE_SIDE,
    QUESTTPE_MISC
}

namespace ZQuesteria.Classes
{
    internal class Quest
    {
        Quest(string szTitle, EQuestType Type)
        {
            this.szTitle = szTitle;
            this.Type = Type;
        }
        public void AddObjective(Objective objective)
        {
            liObjectives.Add(objective);
        }

        private string szTitle;
        private EQuestType Type;
        private List<Objective> liObjectives = new List<Objective>();
    }
}
