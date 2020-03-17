namespace bubblegumMachine
{
    /// <summary>
    ///	denne klasse er en klasse til et Bubblegum objekt
    /// den har name og color som attributer
    /// derudover så tager constructoren disse med når der oprettes
    /// et nyt Bubblegum objekt
    ///
    /// </summary>
	class Bubblegum
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}


        public Bubblegum(string name, string color)
        {
            this.Color = color;
            this.name = name;
        }
    }
}