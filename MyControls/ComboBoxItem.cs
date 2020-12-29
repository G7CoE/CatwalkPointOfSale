using System;
using System.Drawing;

namespace MyControls
{

    /// <summary>
    /// This class represents an ComboBox item of the ImagedComboBox which may contains an image and value.
    /// 
    /// </summary>
    [Serializable]
    public class ComboBoxItem
    {
        private int? _id;
        private Image _image;
        private string _name;

        /// <summary>
        /// ComobBox Item.
        /// </summary>
        public int? ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        /// <summary>
        /// Item image.
        /// </summary>
        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
            }
        }


        public ComboBoxItem()
        {
            _name = String.Empty;
            _image  = new Bitmap(1,1);
        }


        /// <summary>
        /// Constructor item without image.
        /// </summary>
        /// <param name="value">Item value.</param>
        public ComboBoxItem(int id)
        {
            _id = id;
            _image = new Bitmap(1, 1);
        }


        public ComboBoxItem(int id, string name)
        {
            _id = id;
            _name = name;
        }        /// <summary>
                 ///  Constructor item with image.
                 /// </summary>
                 /// <param name="value">Item value.</param>
                 /// <param name="image">Item image.</param>
                 /// 

        public ComboBoxItem(int id, string name, Image image)
        {
            _id = id;
            _name = name;
            _image = image;
        }


        public override string ToString()
        {
            return _id.ToString();
        }
    }
}
