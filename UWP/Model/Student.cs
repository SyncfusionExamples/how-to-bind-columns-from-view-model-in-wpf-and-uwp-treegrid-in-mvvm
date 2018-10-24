using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfTreeGridDemo
{
    class PersonInfo : INotifyPropertyChanged
    {
        #region Private Fields

        private static int _globalId = 0;
        private int _id;
        private string _firstName;
        private string _lastName;
        private bool _likesCake;
        private string _cake = String.Empty;
        private DateTime _dob;
        private string _eyecolor;
        private ObservableCollection<PersonInfo> _children;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>The children.</value>
        public ObservableCollection<PersonInfo> Children
        {
            get
            {
                return _children;
            }
            set
            {
                _children = value;
                OnPropertyChanged("Children");
            }
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [likes cake].
        /// </summary>
        /// <value><c>true</c> if [likes cake]; otherwise, <c>false</c>.</value>
        public bool LikesCake
        {
            get
            {
                return _likesCake;
            }
            set
            {
                _likesCake = value;
                OnPropertyChanged("LikesCake");
            }
        }

        /// <summary>
        /// Gets or sets the cake.
        /// </summary>
        /// <value>The cake.</value>
        public string Cake
        {
            get
            {
                return _cake;
            }
            set
            {
                _cake = value;
                OnPropertyChanged("Cake");
            }
        }

        /// <summary>
        /// Gets or sets the DOB.
        /// </summary>
        /// <value>The DOB.</value>
        public DateTime DOB
        {
            get
            {
                return _dob;
            }
            set
            {
                _dob = value;
                OnPropertyChanged("DOB");
            }
        }

        /// <summary>
        /// Gets or sets the color of my eye.
        /// </summary>
        /// <value>The color of my eye.</value>
        public string MyEyeColor
        {
            get
            {
                return _eyecolor;
            }
            set
            {
                _eyecolor = value;
                OnPropertyChanged("MyEyeColor");
            }
        }

        #endregion

        #region Constructors


        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInfo"/> class.
        /// </summary>
        public PersonInfo()
            : this("Enter FirstName", "Enter LastName", "Enter EyeColor", new DateTime(2008, 10, 26), null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonInfo"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="eyecolor">The eyecolor.</param>
        /// <param name="dob">The dob.</param>
        /// <param name="maxGenerations">The max generations.</param>
        public PersonInfo(string firstName, string lastName, string eyecolor, DateTime dob, ObservableCollection<PersonInfo> child)
        {
            _firstName = firstName;
            _lastName = lastName;
            _eyecolor = eyecolor;
            _likesCake = true;
            _cake = "Chocolate";
            _dob = dob;
            _id = _globalId++;
            _children = child;
        }

        #endregion Constructors

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
