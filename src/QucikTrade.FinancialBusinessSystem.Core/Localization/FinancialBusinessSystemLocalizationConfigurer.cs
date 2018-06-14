using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace QucikTrade.FinancialBusinessSystem.Localization
{
    public static class FinancialBusinessSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FinancialBusinessSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FinancialBusinessSystemLocalizationConfigurer).GetAssembly(),
                        "QucikTrade.FinancialBusinessSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
