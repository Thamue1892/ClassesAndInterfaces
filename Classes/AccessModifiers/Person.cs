using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthDate)
        {
            _birthdate = birthDate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - _birthdate;
                var years = timeSpan.Days / 365;

                return years;

            }
        }
    }
}