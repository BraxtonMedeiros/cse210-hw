class Word
    {
        private string text;
        private bool isShown;

        public Word(string text, bool isShown)
        {
            this.text = text;
            this.isShown = isShown;
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public bool IsShown
        {
            get { return isShown; }
            set { isShown = value; }
        }

        public void Hide()
        {
            isShown = false;
        }

        public void Show()
        {
            isShown = true;
        }
    }