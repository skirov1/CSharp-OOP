namespace _07.MilitaryElite
{
    public class Mission
    {
        private string state;
        public string CodeName { get; set; }
        public string State
        {
            get => this.state;
            set
            {
                {
                    if (value == "Finished" || value == "inProgress")
                    {
                        this.state = value;
                    }
                }
            }
        }
        public void CompleteMission()
        {
            this.State = "Finished";
        }
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public override string ToString()
        {
            if (this.State != null)
            {
                return $"Code Name: {this.CodeName} State: {this.State}";
            }
            return "";
        }
    }
}