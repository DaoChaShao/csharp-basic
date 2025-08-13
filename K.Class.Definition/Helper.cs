namespace K.Class.Definition;

using System;

public class Helper
{
    internal Gender GenderPicker()
    {
        #region Random number setting

        Random random = new Random();

        #endregion

        #region Rondom gender setting

        int genderIndex = random.Next(0, 2);

        // Method I
        Gender[] genders = { Gender.Male, Gender.Female };

        // Method II
        // string[] genders = { nameof(Gender.Male), nameof(Gender.Female) };

        return genders[genderIndex];

        #endregion
    }
}