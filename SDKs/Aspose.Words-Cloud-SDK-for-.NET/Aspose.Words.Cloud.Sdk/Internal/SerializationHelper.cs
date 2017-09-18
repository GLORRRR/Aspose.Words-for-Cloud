﻿namespace Aspose.Words.Cloud.Sdk
{
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class SerializationHelper
    {
        public static string Serialize(object obj)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Serialize:" + JsonConvert.SerializeObject(obj));
                return obj != null
                           ? JsonConvert.SerializeObject(
                               obj,
                               new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
                           : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public static object Deserialize(string json, Type type)
        {
            try
            {
                if (json.StartsWith("{") || json.StartsWith("["))
                {
                    return JsonConvert.DeserializeObject(json, type, new FormFieldJsonConverter());
                }

                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.LoadXml(json);
                return JsonConvert.SerializeXmlNode(xmlDoc);
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
            catch (JsonSerializationException jse)
            {
                throw new ApiException(500, jse.Message);
            }
            catch (System.Xml.XmlException xmle)
            {
                throw new ApiException(500, xmle.Message);
            }
        }

        internal abstract class JsonCreationConverter<T> : JsonConverter
        {
            /// <summary>
            /// Create an instance of objectType, based properties in the JSON object
            /// </summary>
            /// <param name="objectType">type of object expected</param>
            /// <param name="jObject">
            /// contents of JSON object that will be deserialized
            /// </param>
            /// <returns></returns>
            protected abstract T Create(Type objectType, JObject jObject);

            public override bool CanConvert(Type objectType)
            {
                return typeof(T).IsAssignableFrom(objectType);
            }

            public override object ReadJson(
                JsonReader reader,
                Type objectType,
                object existingValue,
                JsonSerializer serializer)
            {
                JObject jObject = JObject.Load(reader);
                T target = this.Create(objectType, jObject);
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }       

        internal class FormFieldJsonConverter : JsonCreationConverter<FormField>
        {
            public override bool CanWrite
            {
                get
                {
                    return false;
                }
            }

            protected override FormField Create(Type objectType, JObject jsonObject)
            {
                if (jsonObject["Checked"] != null)
                {
                    return new FormFieldCheckbox();
                }

                if (jsonObject["TextInputFormat"] != null || jsonObject["TextInputDefault"] != null)
                {
                    return new FormFieldTextInput();
                }

                if (jsonObject["DropDownItems"] != null)
                {
                    return new FormFieldDropDown();
                }

                throw new ApiException(500, "Can not determine formfield type.");
            }
        }
    }
}