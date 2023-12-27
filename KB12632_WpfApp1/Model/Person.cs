using System;
using System.ComponentModel;
using KB12632_WpfApp1.Infrastructure;

namespace KB12632_WpfApp1.Model
{
    internal class Person : ObservableObject, IDataErrorInfo
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        private String _familyName;
        public String FamilyName
        {
            get { return _familyName; }
            set { _familyName = value; OnPropertyChanged(); }
        }

        private String _givenName;
        public String GivenName
        {
            get { return _givenName; }
            set { _givenName = value; OnPropertyChanged(); }
        }

        #region IDataErrorInfo 実装部分
        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                if(columnName == "FamilyName")
                {
                    if (String.IsNullOrEmpty(this._familyName)) return "姓を空欄にすることはできません。";
                }
                return null;
            }
        }
        #endregion

        public Person()
        {
        }
    }
}
