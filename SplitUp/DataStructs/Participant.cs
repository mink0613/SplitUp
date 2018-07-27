namespace SplitUp.DataStructs
{
    public class Participant
    {
        private string name;

        private bool isParticipate;

        private bool isPay;

        public string GetName()
        {
            return name;
        }

        public bool GetIsParticipate()
        {
            return isParticipate;
        }

        public bool GetIsPay()
        {
            return isPay;
        }

        public Participant(string name, bool isParticipate, bool isPay)
        {
            this.name = name;
            this.isParticipate = isParticipate;
            this.isPay = isPay;
        }
    }
}