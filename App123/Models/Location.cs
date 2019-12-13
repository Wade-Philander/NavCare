using System.ComponentModel;
using Xamarin.Forms.Maps;

namespace App123.Models
{
    public class Location : INotifyPropertyChanged
    {
        private Position _position;
        public string Description { get; }
        public string Address { get; }

        public Position Position
        {
            get => _position;
            set
            {
                if (!_position.Equals(value))
                {
                    _position = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
                }

            }
        }
        public Location(string address, string description, Position position)
        {
            Address = address;
            Description = description;
            Position = position;
        }
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion    
    }
    
}
