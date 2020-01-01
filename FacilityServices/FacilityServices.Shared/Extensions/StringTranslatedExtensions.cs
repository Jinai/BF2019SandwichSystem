using FacilityServices.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityServices.Shared.Extensions
{
    public static class StringTranslatedExtensions
    {
        public static T FillFromStringTranslated<T>(this T ToFill, MultiLanguageString stringTranslated)
            where T : IMultiLanguageFields
        {
            ToFill.NameEnglish = stringTranslated.English;
            ToFill.NameFrench = stringTranslated.French;
            ToFill.NameDutch = stringTranslated.Dutch;

            return ToFill;
        }

        public static MultiLanguageString ExtractToStringTranslated(this IMultiLanguageFields Multilanguage)
            => new MultiLanguageString(Multilanguage.NameEnglish, Multilanguage.NameFrench, Multilanguage.NameDutch);
    }
}
