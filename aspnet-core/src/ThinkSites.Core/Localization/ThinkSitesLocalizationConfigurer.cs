using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ThinkSites.Localization
{
    public static class ThinkSitesLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ThinkSitesConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ThinkSitesLocalizationConfigurer).GetAssembly(),
                        "ThinkSites.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
