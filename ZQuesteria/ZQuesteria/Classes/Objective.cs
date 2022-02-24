using System;
using System.Collections.Generic;
using System.Text;

enum EState
{
    STATUS_NULL = 0,
    STATUS_CURRENT,
    STATUS_OK,
    STATUS_FAILED
}

namespace ZQuesteria.Classes
{
    internal class Objective
    {
        Objective(string szTitle, int iPosition = 0, bool isOptional = false)
        {
            this.szTitle = szTitle;
            this.iPosition = iPosition;
            this.isOptional = isOptional;
        }

        public EState iState = EState.STATUS_NULL;
        private int iPosition;
        private bool isOptional;
        private string szTitle;
    }
}
