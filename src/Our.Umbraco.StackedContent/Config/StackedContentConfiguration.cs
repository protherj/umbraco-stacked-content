﻿using Newtonsoft.Json;
using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.StackedContent.Config
{
    public class StackedContentConfiguration
    {
        [ConfigurationField("contentTypes", "Document types", "~/App_Plugins/StackedContent/views/stackedcontent.doctypepicker.html", Description = "Select the document types to use as the item blueprints. Only \"element\" types can be used.")]
        public ContentType[] ContentTypes { get; set; }

        [ConfigurationField("minItems", "Min Items", "number", Description = "Set the minimum number of items allowed.")]
        public int? MinItems { get; set; }

        [ConfigurationField("maxItems", "Max Items", "number", Description = "Set the maximum number of items allowed.")]
        public int? MaxItems { get; set; }

        [ConfigurationField("confirmDeletes", "Confirm Deletes", "boolean", Description = "Set whether item deletions should require confirming.")]
        public bool ConfirmDeletes { get; set; } = true;

        [ConfigurationField("showIcons", "Show Icons", "boolean", Description = "Set whether to show the items doc type icon in the list.")]
        public bool ShowIcons { get; set; } = true;

        [ConfigurationField("hideLabel", "Hide Label", "boolean", Description = "Set whether to hide the editor label and have the list take up the full width of the editor window.")]
        public bool HideLabel { get; set; }

        public class ContentType
        {
            [JsonProperty("scAlias")]
            public string Alias { get; set; }

            [JsonProperty("nameTemplate")]
            public string Template { get; set; }
        }
    }
}
