using System;
using System.Collections.Generic;

namespace SplitUp.DataStructs
{
    class SplitData
    {
        private DateTime time;

        private List<Participant> participants;

        private int amount;

        private string payer;

        public DateTime GetTime()
        {
            return time;
        }

        public List<Participant> GetParticipants()
        {
            return participants;
        }

        public int GetAmount()
        {
            return amount;
        }

        public string GetPayer()
        {
            return payer;
        }

        public SplitData(DateTime time, List<Participant> participants, int amount, string payer)
        {
            this.time = time;
            this.participants = participants;
            this.amount = amount;
            this.payer = payer;
        }
    }
}