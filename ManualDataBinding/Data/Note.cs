 using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        public event EventHandler NoteChanged;

        /// <summary>
        /// The title of the Note
        /// </summary>
        private string title = DateTime.Now.ToString();
        public string Title 
        {
            get { return title; }
            set
            {
                if (title == value) return;
                title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            } 
        }

        /// <summary>
        /// The text of the note
        /// </summary>
        private string body = "";
        public string Body 
        {
            get { return body; }
            set
            {
                if (body == value) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            } 
        }
    }
}
