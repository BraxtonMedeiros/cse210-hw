using System;

class Reference
    {
        private string book;
        private int chapter;
        private int startVerse;
        private int endVerse;

        public Reference(string book, int chapter, int startVerse, int endVerse = 0)
        {
            this.book = book;
            this.chapter = chapter;
            this.startVerse = startVerse;
            this.endVerse = endVerse;
        }

        public string Book
        {
            get { return book; }
            set { book = value; }
        }

        public int Chapter
        {
            get { return chapter; }
            set { chapter = value; }
        }

        public int StartVerse
        {
            get { return startVerse; }
            set { startVerse = value; }
        }

        public int EndVerse
        {
            get { return endVerse; }
            set { endVerse = value; }
        }

        public string GetReferenceString()
        {
            string referenceString = book + " " + chapter + ":" + startVerse;

            if (endVerse > 0)
            {
                referenceString += "-" + endVerse;
            }

            return referenceString;
        }
    }