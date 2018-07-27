using System.Collections.Generic;

namespace SplitUp.DataStructs
{
    public class MeetingData
    {
        private string name;
        private int totalParticipate;
        private int totalAmount;
        private List<SplitData> data;

        public MeetingData(string name, int totalParticipate, int totalAmount, List<SplitData> data)
        {
            this.name = name;
            this.totalParticipate = totalParticipate;
            this.totalAmount = totalAmount;
            this.data = data;
        }

        public string GetName()
        {
            return name;
        }

        public int GetTotalParticipate()
        {
            return totalParticipate;
        }

        public int GetTotalAmount()
        {
            return totalAmount;
        }

        public List<SplitData> GetSplitData()
        {
            return data;
        }
    }
}